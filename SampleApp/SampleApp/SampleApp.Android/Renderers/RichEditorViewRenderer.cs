using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using JP.Wasabeef.Richeditor;
using SampleApp.Controls;
using SampleApp.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RichEditorView), typeof(RichEditorViewRenderer))]
namespace SampleApp.Droid.Renderers
{
    public class RichEditorViewRenderer: ViewRenderer<RichEditorView, LinearLayout>
    {
        public RichEditorViewRenderer(Context context) : base(context)
        {

        }

        private LinearLayout layout;

        protected override void OnElementChanged(ElementChangedEventArgs<RichEditorView> e)
        {            
            var x = Inflate(Context, Resource.Layout.richeditorlayout, null);
            if (layout == null)
            {
                layout = x as LinearLayout;
            }
            var control = layout.FindViewById<RichEditor>(Resource.Id.theeditor);
            MessagingCenter.Subscribe<object>(this, MainPage.undoConst, d => 
            {
                control.Undo();
            });
            MessagingCenter.Subscribe<object>(this, MainPage.redoConst, d =>
            {
                control.Redo();
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead1Const, d =>
            {
                control.SetHeading(1);
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead2Const, d =>
            {
                control.SetHeading(2);
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead3Const, d =>
            {
                control.SetHeading(3);
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead4Const, d =>
            {
                control.SetHeading(4);
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead5Const, d =>
            {
                control.SetHeading(5);
            });
            MessagingCenter.Subscribe<object>(this, MainPage.setHead6Const, d =>
            {
                control.SetHeading(6);
            });
            SetNativeControl(layout);
        }
    }
}