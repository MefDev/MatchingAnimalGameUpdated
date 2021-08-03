using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MyselfDoingTheMatchingProducts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer time = new DispatcherTimer();
        
        
       

        public MainWindow()
        {
            InitializeComponent();

            time.Interval = new TimeSpan(0,0,0,1);
            time.Tick += Timer_Tick;

            PlayThisGame();
        }







        private void PlayThisGame()
        {
            List<string> EmojiAnimal = new List<string>()
            {
                "🦄", "🦄",
                "🐼", "🐼",
                "🐸", "🐸",
                "🐹", "🐹",
                "🦒", "🦒",
                "🐨", "🐨",
                "🐗", "🐗",
                "🐮", "🐮",
            };

            

            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(EmojiAnimal.Count);
                if (EmojiAnimal.Count > index)
                {

               
                string nextEmoji = EmojiAnimal[index];
                textBlock.Text = nextEmoji;
                EmojiAnimal.RemoveAt(index);
                
                    }

                time.Start();
                
            }


            List<string> newAnimalEmoj = new List<string>()
             {
                 "🐯", "🐯",
                "🐱", "🐱",
                "🐱", "🐱",
                "🦊", "🦊",
                "🦒", "🦒",
                "🐶", "🐶",
                "🐵", "🐵",
                "🦓", "🦓"
             };
            if (isMatch == 8)
            {
                EmojiAnimal = newAnimalEmoj;
               
            }
           
            
                       
             







        }
        int isMatch = 0;
        int counter = 60;
        string lastTimeAchieved;




        private void Timer_Tick(object sender, EventArgs e)
        {

             
            time.Start();
            counter--;
            timeTextBlock.Text = counter.ToString(" 0S");
            if (isMatch == 8)
            {
                time.Stop();

                lastTimeAchieved = timeTextBlock.Text;
                
                timeTextBlock.Text = lastTimeAchieved  + " Beat it Next Time ?";

                

            }
           
        }



        TextBlock lastEmojiClicked;
        bool isMatching = false;

        private void AppearOrDispear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textblock = sender as TextBlock;
            if (isMatching == false)
            {
                
                textblock.Visibility = Visibility.Hidden;
                lastEmojiClicked = textblock;

                isMatching = true;
                
            }
            else if (  textblock.Text == lastEmojiClicked.Text)
            {
                isMatch++;
                textblock.Visibility = Visibility.Hidden;
               
                isMatching = false;
                

            }
            else
            {
                
                lastEmojiClicked.Visibility = Visibility.Visible;
                isMatching = false;
               
            }
           

        }


        private void TimeElapse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            if (isMatch == 8)
            {
                
                PlayThisGame();
                
            }
 

        }
    }
}
