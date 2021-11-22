using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Streams;
using System.Media;
using AudioPlayerSample;
using NAudio;
using NAudio.Wave;
using System.IO;
using System.Text.RegularExpressions;

namespace Tacotron_Transcription_Auditor
{
    public partial class Form1 : Form
    {
        public Dictionary<String, String> transcriptions = new Dictionary<string, string>();
        public int current_line_number = 0;
        public MusicPlayer _musicPlayer = new MusicPlayer();
        public int seconds_left = 0;
        public int current_file_length = 0;
        public MMDevice default_device;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public Regex rx = new Regex(@".*\/(.*)\|(.*)",
                  RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public bool loaded_shit = false;
        public Form1()
        {
            InitializeComponent();
            var mmdeviceEnumerator = new MMDeviceEnumerator();
            default_device = mmdeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            outputDevice = new WaveOutEvent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void play_audio()
        {
            outputDevice.Stop();
            _musicPlayer.Stop();
            var audio_to_play = audio_dir_path.Text + "/" + transcriptions.ElementAt(current_line_number).Key;
            if (Path.GetExtension(audio_to_play) == ".wav")
            {
                audioFile = new AudioFileReader(audio_to_play);
                outputDevice.Init(audioFile);
                outputDevice.Play();
            }
            else
            {
                _musicPlayer.Open(audio_to_play, default_device);
                _musicPlayer.Play();
            }
        }
        private void play_button_Click(object sender, EventArgs e)
        {
            play_audio();
        }

        private void load_ds_button_Click(object sender, EventArgs e)
        {
            if (dataset_path.Text != null && audio_dir_path.Text != null)
            {
                StreamReader file = new StreamReader(dataset_path.Text);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Match regex_match = rx.Match(line);
                    transcriptions.Add(regex_match.Groups[1].Value, regex_match.Groups[2].Value);
                }
                file.Close();
                ChangeLineInBox();
                UpdateProgressBar();
            }
            loaded_shit = true;
            play_button.Enabled = true;
            transcription_delete_button.Enabled = true;
            next_button.Enabled = true;
            previous_button.Enabled = true;
            save_dataset_button.Enabled = true;
            transcription_box.Enabled = true;
            play_audio();
        }
        public void SaveTranscriptionLine()
        {
            transcriptions[transcriptions.ElementAt(current_line_number).Key] = transcription_box.Text;
        }
        public void ChangeLine(bool up_or_down)
        {
            SaveTranscriptionLine();
            if (up_or_down)
            {
                if ((current_line_number + 1) < transcriptions.Count())
                {
                    current_line_number++;
                    ChangeLineInBox();
                    UpdateProgressBar();
                }
            }
            else
            {
                if (current_line_number > 0)
                {
                    current_line_number--;
                    ChangeLineInBox();
                    UpdateProgressBar();
                }
            }
            if (autoplay_check.Checked)
            {
                play_audio();
            }
        }
        public void UpdateProgressBar()
        {
            progbar.Maximum = transcriptions.Count() - 1;
            progbar.Value = current_line_number;
            int current_num = progbar.Value + 1;
            int max_num = transcriptions.Count();
            progress_label.Text = current_num.ToString() + " of " + max_num.ToString();
        }
        public void ChangeLineInBox()
        {
            transcription_box.Text = transcriptions.ElementAt(current_line_number).Value;
            filename_label.Text = transcriptions.ElementAt(current_line_number).Key;
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            ChangeLine(true);
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            ChangeLine(false);
        }

        private void transcription_delete_button_Click(object sender, EventArgs e)
        {
            transcription_box.Text = "%DELETED_LINE%";
            ChangeLine(true);
        }

        private void save_dataset_button_Click(object sender, EventArgs e)
        {
            save_dataset();
        }
        private void save_dataset()
        {
            SaveTranscriptionLine();
            var dataset_dir = Path.GetDirectoryName(dataset_path.Text);
            var file_name_dataset = Path.GetFileNameWithoutExtension(dataset_path.Text);
            var new_dataset = audited_save_loc.Text;
            Console.WriteLine(new_dataset);
            if (File.Exists(new_dataset))
            {
                File.Delete(new_dataset);
            }
            var dataset_file_new = File.Create(new_dataset);
            foreach (var transcription in transcriptions)
            {
                if (transcription.Value == "%DELETED_LINE%")
                {
                    continue;
                }
                Byte[] transcript = new UTF8Encoding(true).GetBytes("audio/" + transcription.Key + "|" + transcription.Value + "\n");
                dataset_file_new.Write(transcript, 0, transcript.Length);
            }
            dataset_file_new.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.PageDown && loaded_shit)
            {
                ChangeLine(true);
                return true;
            }
            if (keyData == Keys.PageUp && loaded_shit)
            {
                ChangeLine(false);
                return true;
            }
            if (keyData == Keys.End && loaded_shit)
            {
                play_audio();
                return true;
            }
            if (keyData == Keys.Delete && loaded_shit)
            {
                transcription_box.Text = "%DELETED_LINE%";
                ChangeLine(true);
                return true;
            }
            if (keyData == (Keys.Control | Keys.S) && loaded_shit)
            {
                save_dataset();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
