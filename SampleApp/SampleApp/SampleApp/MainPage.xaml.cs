using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public const string undoConst = "undo";
        public const string redoConst = "redo";
        public const string setHead1Const = "setHead1";
        public const string setHead2Const = "setHead2";
        public const string setHead3Const = "setHead3";
        public const string setHead4Const = "setHead4";
        public const string setHead5Const = "setHead5";
        public const string setHead6Const = "setHead6";

        private void UnDoBtn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), undoConst);
        }

        private void ReDoBtn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), redoConst);
        }

        private void SetHead1Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead1Const);
        }

        private void SetHead2Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead2Const);
        }

        private void SetHead3Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead3Const);
        }

        private void SetHead4Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead4Const);
        }

        private void SetHead5Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead5Const);
        }

        private void SetHead6Btn_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new object(), setHead6Const);
        }
    }
}
