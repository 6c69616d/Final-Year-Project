using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Xamarin.Essentials;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.IO;

namespace TestApk
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, 
                    ScreenOrientation = ScreenOrientation.Landscape)]

    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            SetContentView(Resource.Layout.activity_main);
            //Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);

            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;

            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.Click += QbuttonOnClick;
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.Click += WbuttonOnClick;
            Button e = FindViewById<Button>(Resource.Id.ebutton);
            e.Click += EbuttonOnClick;
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.Click += RbuttonOnClick;
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.Click += TbuttonOnClick;
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.Click += YbuttonOnClick;
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.Click += UbuttonOnClick;
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.Click += IbuttonOnClick;
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.Click += ObuttonOnClick;
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.Click += PbuttonOnClick;
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.Click += AbuttonOnClick;
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.Click += SbuttonOnClick;
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.Click += DbuttonOnClick;
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.Click += FbuttonOnClick;
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.Click += GbuttonOnClick;
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.Click += HbuttonOnClick;
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.Click += JbuttonOnClick;
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.Click += KbuttonOnClick;
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.Click += LbuttonOnClick;
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.Click += ZbuttonOnClick;
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.Click += XbuttonOnClick;
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.Click += CbuttonOnClick;
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.Click += VbuttonOnClick;
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.Click += BbuttonOnClick;
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.Click += NbuttonOnClick;
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.Click += MbuttonOnClick;
            Button del = FindViewById<Button>(Resource.Id.deletebutton);
            del.Click += DelbuttonOnClick;
            //Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            //speak.Click += SpeakbuttonOnClick;
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.Click += SpacebuttonOnClick;
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.Click += ImageButtonOnClick;
        }

        private void ImageButtonOnClick(object sender, EventArgs e)
        {
            SpeakNowDefaultSettings();
        }

        private void SpacebuttonOnClick(object sender, EventArgs e)
        {
            ChangeText(" ");
        }

        private void SpeakbuttonOnClick(object sender, EventArgs e)
        {
           SpeakNowDefaultSettings();
        }

        private void MbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("m");
        }

        private void NbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("n");
        }

        private void BbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("b");
        }

        private void VbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("v");
        }

        private void CbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("c");
        }

        private void XbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("x");
        }

        private void ZbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("z");
        }

        private void LbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("l");
        }

        private void KbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("k");
        }

        private void JbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("j");
        }
        private void HbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("h");
        }

        private void GbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("g");
        }

        private void FbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("f");
        }

        private void DbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("d");
        }

        private void SbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("s");
        }

        private void AbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("a");
        }

        private void PbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("p");
        }

        private void ObuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("o");
        }

        private void IbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("i");
        }

        private void UbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("u");
        }

        private void YbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("y");
        }

        private void TbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("t");
        }

        private void RbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("r");
        }

        private void EbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("e");
        }

        private void WbuttonOnClick(object sender, EventArgs e)
        {
            ChangeText("w");
        }

        private void QbuttonOnClick(object sender, EventArgs e)
        {
            //View view = (View)sender;
            //Snackbar.Make(view, "Q BUTTON CLICKED", Snackbar.LengthLong)
            //      .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
            ChangeText("q");
        }

        private void DelbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            string currentText = txtWord.Text;
            if (!string.IsNullOrEmpty(currentText))
            {
                currentText = currentText.Remove(currentText.Length - 1);
                txtWord.Text = currentText;
            }
            else
            {
                txtWord.Text = "search";
            }
        }

        public void ChangeText(String letter)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            string currentText = txtWord.Text;

            if (currentText == "search")
            {
                txtWord.Text = "";
                txtWord.Text += letter;
                DoesSymbolExist(txtWord.Text);
            }
            else
            {
                txtWord.Text += letter;
                DoesSymbolExist(txtWord.Text);
            }
            
        }

        private void SetButtonImageToSymbol(int resourceId)
        {
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetImageResource(resourceId);
            imageButton.Visibility = ViewStates.Visible;
        }

        public void DoesSymbolExist(string symbol)
        {   
            var context = Android.App.Application.Context;
            var resources = context.Resources;
            var name = Path.GetFileNameWithoutExtension(symbol);
            int resourceId = resources.GetIdentifier(name, "drawable", context.PackageName);

            if (resourceId != 0)
            {
                SetButtonImageToSymbol(resourceId);
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public async Task SpeakNowDefaultSettings()
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            string currentText = txtWord.Text;
            await TextToSpeech.SpeakAsync(currentText);
        }


        //private void FabOnClick(object sender, EventArgs eventArgs)
        //{
        //    View view = (View) sender;
        //    Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
        //        .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        //}
    }
}

