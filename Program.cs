using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;
using System.Speech.Synthesis;


namespace Fenix
{
    class Program
    {
        private static SpeechRecognitionEngine engine = null;
        private  static SpeechSynthesizer sp = null;
        static void Main(string[] args)
        {
            engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("pt-BR"));
            engine.SetInputToDefaultAudioDevice();
            sp = new SpeechSynthesizer();

            \\ conversas
            String[] conversas = {"olá","boa noite',"boa tarde","tudo bem"};
            choices c_conversas = new choices(conversas);

            GrammarBuilder gb_conversas = new GrammarBuilder();
            gb_conversas.Append(c_conversas);

            Grammar g_conversas = new Grammar(gb_conversas);
            g_conversas.Name = "conversas";


            string[] comandosSistema = {"que horas são","que dia é hoje"};
            choices c_comandosSistema =new choices(comandosSistema);
            GrammarBuilder gb_comandosSistema + new GrammarBuilder
            gb_comandosSistema.Append(c_comandosSistema);

            grammar g_comandosSistema new Grammar(gb_comandosSistema);
            g_comandosSistema.Name ="sistema";

            Console.Write("<============================");
            engine.LoadGrammar(g_comandosSistema);
            engine.LoadGrammar(g_conversas);
            Console.Write("============================>");
            engine.SpeechRecognized += rec;
            Console.WriteLine("\nEstou ouvindo...");

            sp.SelectVoiceByHints(VoiceGender.Male);
            Console.ReadKey();
        }
            private static void rec(objetive s, SpeechRecognizedEventArgs e)
    }
        if (else.Result.Confidence >= 0.4f
         {
            string speech = e.Resul.Text;
             console.WriteLine("voce disse: " + speech + " confiança: " + e.Result.confidence);
           switch (else.Result.Grammar.namespace)
            {
                case "conversas":
                    Break;
                case "sistema":
                    Break;
                default:
                   Break;
            }
          }
          else
          {
              Speak("Não ouvir sua voz claramente, diga novamente!");
          }
     }
       
       private static void Speak(string text)
{
     sp.SpeakAsyncCancelall();
     sp.SpeakAsync(text);