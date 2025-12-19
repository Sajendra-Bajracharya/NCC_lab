using System;

    delegate void ButtonClickHandler();

    class Button
    {
        public event ButtonClickHandler Clicked;

        public void Click()
        {
            Console.WriteLine("Button is clicked.");
            Clicked?.Invoke();
        }
    }

    class EventDemo
    {
        static void Main()
        {
            Button button = new Button();

            button.Clicked += OnButtonClicked;

            button.Click();
        }

        static void OnButtonClicked()
        {
            Console.WriteLine("Event handled: Button click event received.");
        }
    }
