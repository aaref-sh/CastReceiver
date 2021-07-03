using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using Microsoft.AspNetCore.SignalR.Client;
using TextBlock = Emoji.Wpf.TextBlock;

namespace CastReceiver
{
    /// <summary>
    /// Interaction logic for WPFChatForm.xaml
    /// </summary>
    public partial class WPFChatForm : UserControl
    {
        bool mic_muted = true;
        bool speaker_muted = false;
        public WPFChatForm() => InitializeComponent();
        public void adds() => Form1.connection.On<string, string>("newMessage", NewMessage);
        void NewMessage(string sender, string message)
        {
            Border b = new Border();
            b.CornerRadius = new CornerRadius(8);
            b.BorderBrush = (sender == Form1.myname) ? Brushes.DarkGreen : Brushes.Gray;
            if(sender == "Teacher") b.BorderBrush = Brushes.DarkRed;
            b.BorderThickness = new Thickness(2);

            Frame container = new Frame();
            //b.Margin = new Thickness(5,5,5,0);
            StackPanel msg = new StackPanel();
            WrapPanel panel = new WrapPanel();
            Label sndr = new Label();
            sndr.FontSize = 11;
            sndr.Foreground = (sender == Form1.myname) ? Brushes.DarkGreen : Brushes.DarkGray;
            container.MouseDoubleClick += Container_MouseDoubleClick;
            TextBlock mesg = new TextBlock();
            mesg.Text = Form1.Decoded(message);
            mesg.TextWrapping = TextWrapping.Wrap;
            mesg.FontSize = 16;
            mesg.FontFamily = new FontFamily("Times New Roman");
            mesg.Foreground = Brushes.Black;
            mesg.Margin = new Thickness (3,0,3,3);
            sndr.Content = sender;
            if (ia(message[0])) mesg.FlowDirection = FlowDirection.RightToLeft;
            msg.Children.Add(sndr);
            msg.Children.Add(mesg);
            container.Content = msg;

            b.Child = container;
            WrapPanel wp = new WrapPanel();
            wp.Margin = new Thickness(5, 5, 5, 0);
            wp.Children.Add(b);
            MessageList.Children.Add(wp);
            scrollViewer.ScrollToEnd();
        }

        private void Container_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var text = (((sender as Frame).Content as StackPanel).Children[1] as TextBlock).Text;
                Clipboard.SetText(text);
                (((sender as Frame).Content as StackPanel).Children[1] as TextBlock).Text = "تم النسخ ✔";
                reset(sender, text);
            }
            catch { }
        }
        async void reset(Object sender, string text)
        {
            await System.Threading.Tasks.Task.Delay(500).ContinueWith(_ => { });
            (((sender as Frame).Content as StackPanel).Children[1] as TextBlock).Text = text;

        }
        public static bool ia(char glyph)
        {
            if (glyph >= 0x600 && glyph <= 0x6ff) return true;
            if (glyph >= 0x750 && glyph <= 0x77f) return true;
            if (glyph >= 0xfb50 && glyph <= 0xfc3f) return true;
            if (glyph >= 0xfe70 && glyph <= 0xfefc) return true;
            return false;
        }
        public void Image_MouseLeftButtonDown(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Trim() != string.Empty)
            {
                Form1.connection.InvokeAsync("newMessage", Form1.Decoded(MessageTextBox.Text.Trim()));
                MessageTextBox.Text = "";
            }
        }
        private void picker_Picked(object sender, Emoji.Wpf.EmojiPickedEventArgs e) => MessageTextBox.Text += e.Emoji;
        public void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            picker.Focus();
            MessageTextBox.Focus();
            if (e.Key == Key.Enter && MessageTextBox.Text.Trim() != string.Empty)
            {
                Form1.connection.InvokeAsync("newMessage", Form1.Decoded(MessageTextBox.Text.Trim()));
                MessageTextBox.Text = "";
            }
        }
        public void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MessageTextBox.Text.Trim() != string.Empty)
                if (ia(MessageTextBox.Text[0]))MessageTextBox.FlowDirection = FlowDirection.RightToLeft;
                else MessageTextBox.FlowDirection = FlowDirection.LeftToRight;
        }
        public void pbmic(Object sender,EventArgs e)
        {
            mic.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/" +(mic_muted?"mu.png":"mm.png")));
            mic_muted = !mic_muted;
            Form1.sc.mictougle();
        }
        public void pbspeaker(Object sender,EventArgs e)
        {
            speaker.Source = new BitmapImage(new Uri("pack://siteoforigin:,,,/Resources/" +(speaker_muted?"su.png":"sm.png")));
            speaker_muted = !speaker_muted;
            Form1.sc.speakertougle();
        }
    }
}
