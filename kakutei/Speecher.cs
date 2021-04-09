using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Media;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace kakutei
{
	class Speecher : IDisposable
	{
		private SpeechSynthesizer _speech = new SpeechSynthesizer();
		private FileStream[]  _waveFiles = new FileStream[0];
		private MediaPlayer[] _numPlayer;

		public Speecher()
		{
			_waveFiles = GenerateNumFile();
			_numPlayer = GenerateNumPlayer(_waveFiles);
			_speech.SetOutputToDefaultAudioDevice();
		}

		public void Dispose()
		{
			_waveFiles.All((file) =>
			{
				file.Dispose();
				return true;
			});
		}

		private FileStream[] GenerateNumFile()
		{
			List<FileStream> fileList = new List<FileStream>();

			try
			{
				for (int i = 0; i < 10; ++i)
				{
					string tmpFile = Path.GetTempFileName();
					tmpFile = Path.ChangeExtension(tmpFile, ".wav");

					_speech.SetOutputToWaveFile(tmpFile);
					_speech.Speak($"{i}");
					_speech.SetOutputToNull();

					FileStream file = new FileStream(tmpFile, FileMode.Open, FileAccess.Read, FileShare.Read, 1024, FileOptions.DeleteOnClose);
					fileList.Add(file);
				}

				return fileList.ToArray();
			}
			catch
			{
				fileList.ForEach((file) => file.Dispose());
				return new FileStream[0];
			}
		}

		private MediaPlayer[] GenerateNumPlayer(FileStream[] numFileList)
		{
			return numFileList.Select((file) =>
			{
				MediaPlayer p = new MediaPlayer();
				p.Open(new Uri($"file:///{file.Name}"));
				return p;
			}).ToArray();
		}

		public void Speech(string text)
		{
			_speech.Speak(text);
		}

		public void SpeechLastChar(string text)
		{
			if (string.IsNullOrEmpty(text))
				return;

			string c = text.Last().ToString();
			if (int.TryParse(c, out int num) && (num < _numPlayer.Length))
			{
				MediaPlayer player = _numPlayer[num];
				player.Stop();
				player.Position = new TimeSpan(0);
				player.Play();
			}
			else
			{
				Speech(c);
			}
		}
	};

}
