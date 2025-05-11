using System;
using System.Collections.Generic;
using System.Windows;

namespace DataGridApp
{    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Alice", BirthDate = new DateTime(1990, 1, 1),
                    ImageUrl="https://www.onthisday.com/images/people/homer-simpson.jpg" },
                new User { Id = 2, Name = "Bob", BirthDate = new DateTime(1985, 5, 15) },
                new User { Id = 3, Name = "Charlie", BirthDate = new DateTime(2000, 10, 20) }
            };

            dg.ItemsSource = users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Details
        {
            get
            {
                return $"{Name}, дата народження {BirthDate.ToLongDateString()}, а це довгий текст опису обраного користувача.";
            }
        }
        public string ImageUrl { get; set; }
    }
}
