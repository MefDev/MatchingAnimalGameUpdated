﻿using System;
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

namespace MatchTheseThings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpThisGame();
        }

        private void SetUpThisGame()
        {
            List<string> AnimalEmoji = new List<string>()
            {
                "🦧", "🦧",
                "🦊", "🦊",
                "🐱", "🐱",
                "🐯", "🐯",
                "🦄", "🦄",
                "🐷", "🐷",
                "🐹", "🐹",
                "🐻", "🐻",
            };

            Random random = new Random();
            foreach (TextBlock  textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(AnimalEmoji.Count);
               if (index > 0 && index < AnimalEmoji.Count )
                { 
                string nextEmoji = AnimalEmoji[index];
                textBlock.Text = nextEmoji;
                    AnimalEmoji.RemoveAt(index);
                }


            }

            
                }

            }
        }
    


