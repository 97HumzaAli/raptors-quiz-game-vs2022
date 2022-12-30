using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace RaptorsQuizA1HumzaAli
{
    internal class GenerateQA
    {
        int[] sequence = new int[7];
        QuestionsAnswers[] qa = new QuestionsAnswers[7];
        public QuestionsAnswers[] GenerateSequence(QuestionsAnswers q1, QuestionsAnswers q2, QuestionsAnswers q3, QuestionsAnswers q4, QuestionsAnswers q5, QuestionsAnswers q6, QuestionsAnswers q7)
        {

            qa[0] = q1;
            qa[1] = q2;
            qa[2] = q3;
            qa[3] = q4;
            qa[4] = q5;
            qa[5] = q6;
            qa[6] = q7;

            foreach (QuestionsAnswers q in qa)
            {
                Console.WriteLine(q.Q);
            }

            return Randomize(qa);
        }

        public static QuestionsAnswers[] Randomize(QuestionsAnswers[] qa)
        {
            Random random = new Random();
            int[] sequence = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(8);
                while (sequence.Contains(randomNumber))
                {
                    randomNumber = random.Next(8);
                }
                sequence[i] = randomNumber;
            }

            QuestionsAnswers[] randomQa = new QuestionsAnswers[7];
            int count = 0;
            foreach (int position in sequence)
            {
                if (position < 0)
                {
                    randomQa[0] = qa[count];
                    Console.WriteLine(position - 1);
                    count++;
                }
                else
                {
                    randomQa[position - 1] = qa[count];
                    Console.WriteLine(position - 1);
                    count++;

                }                  
            }
            foreach (QuestionsAnswers q in randomQa)
            {
                Console.WriteLine(q.Q);
            }
            return randomQa;
        }
    }
}
