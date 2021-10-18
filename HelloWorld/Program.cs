using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Speech.Synthesis;
using Windows.UI.Xaml.Controls;
using Windows.Media.SpeechSynthesis;
using System.Speech;

namespace HelloWorld
{
    class Program
    {
        public static void Main()
        {
           SynthesizeAudioAsync();
        }

        public static void SynthesizeAudioAsync()
        {
            var config = SpeechConfig.FromSubscription("c4d8ff0e196c46d69ecd6f9e3cbca15d", "eastus");
            config.SetSpeechSynthesisOutputFormat(SpeechSynthesisOutputFormat.Riff24Khz16BitMonoPcm);

            var synthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            synthesizer.Speak("Now the computer is speaking to you.");
            
            //System.Speech.Synthesis.SpeechSynthesizer speechSynthesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            //PromptBuilder promptBuilder = new PromptBuilder();
            //SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();
            //speechSynthesizer.Speak("Hello");

        }

    }
}
