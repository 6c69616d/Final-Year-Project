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
        string image;
        bool symbolClicked;
        bool speechClicked;
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
            Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            speak.Click += SpeakbuttonOnClick;
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.Click += SpacebuttonOnClick;
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.Click += ImageButtonOnClick;
            Button clear = FindViewById<Button>(Resource.Id.clearbutton);
            clear.Click += ClearbuttonOnClick;
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.Click += QwertybuttonOnClick;
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.Click += AlphabetbuttonOnClick;
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.Click += FrequencybuttonOnClick;
            Button keyboards = FindViewById<Button>(Resource.Id.keyboardsbutton);
            keyboards.Click += KeyboardsbuttonOnClick;
        }

        private void KeyboardsbuttonOnClick(object sender, EventArgs e)
        {
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.Visibility = ViewStates.Visible;
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.Visibility = ViewStates.Visible;
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.Visibility = ViewStates.Visible;
        }

        private void FrequencybuttonOnClick(object sender, EventArgs e)
        {
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.Text = "E";
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.Text = "T";
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.Text = "A";
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.Text = "S";
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.Text = "H";
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.Text = "R";
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.Text = "U";
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.Text = "M";
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.Text = "F";
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.Visibility = ViewStates.Invisible;
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.Text = "O";
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.Text = "I";
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.Text = "N";
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.Text = "D";
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.Text = "L";
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.Text = "C";
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.Text = "W";
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.Text = "G";
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.Text = "Y";
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.Text = "P";
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.Text = "B";
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.Text = "V";
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.Text = "K";
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.Text = "J";
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.Text = "X";
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.Text = "Q";
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.Visibility = ViewStates.Visible;
            HideKeyboardLayoutButtons();

        }

        private void HideKeyboardLayoutButtons()
        {
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.Visibility = ViewStates.Invisible;
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.Visibility = ViewStates.Invisible;
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.Visibility = ViewStates.Invisible;
        }

        private void AlphabetbuttonOnClick(object sender, EventArgs e)
        {
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.Text = "A";
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.Text = "B";
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.Text = "C";
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.Text = "D";
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.Text = "E";
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.Text = "F";
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.Text = "G";
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.Text = "H";
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.Text = "I";

            Button p = FindViewById<Button>(Resource.Id.pbutton);
            if (p.Visibility == ViewStates.Invisible)
            {
                p.Visibility = ViewStates.Visible;
                Button extra = FindViewById<Button>(Resource.Id.extrabutton);
                extra.Visibility = ViewStates.Invisible;
            }
                p.Text = "J";
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.Text = "K";
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.Text = "L";
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.Text = "M";
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.Text = "N";
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.Text = "O";
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.Text = "P";
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.Text = "Q";
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.Text = "R";
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.Text = "S";
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.Text = "T";
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.Text = "U";
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.Text = "V";
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.Text = "W";
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.Text = "X";
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.Text = "Y";
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.Text = "Z";
            HideKeyboardLayoutButtons();
        }

        private void QwertybuttonOnClick(object sender, EventArgs e)
        {
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.Text = "Q";
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.Text = "W";
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.Text = "E";
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.Text = "R";
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.Text = "T";
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.Text = "Y";
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.Text = "U";
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.Text = "I";
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.Text = "O";
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            if (p.Visibility == ViewStates.Invisible)
            {
                p.Visibility = ViewStates.Visible;
                Button extra = FindViewById<Button>(Resource.Id.extrabutton);
                extra.Visibility = ViewStates.Invisible;
            }
            p.Text = "P";
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.Text = "A";
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.Text = "S";
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.Text = "D";
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.Text = "F";
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.Text = "G";
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.Text = "H";
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.Text = "J";
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.Text = "K";
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.Text = "L";
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.Text = "Z";
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.Text = "X";
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.Text = "C";
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.Text = "V";
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.Text = "B";
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.Text = "N";
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.Text = "M";
            HideKeyboardLayoutButtons();
        }

        private void ClearbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            txtWord.Text = "search";
        }

        private void ImageButtonOnClick(object sender, EventArgs e)
        {
            symbolClicked = true;
            SpeakNowDefaultSettings();
        }

        private void SpacebuttonOnClick(object sender, EventArgs e)
        {
            ChangeText(" ");
        }

        private void SpeakbuttonOnClick(object sender, EventArgs e)
        {
            speechClicked = true;
            SpeakNowDefaultSettings();
        }

        private void MbuttonOnClick(object sender, EventArgs e)
        {
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            ChangeText(m.Text.ToLower());
        }

        private void NbuttonOnClick(object sender, EventArgs e)
        {
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            ChangeText(n.Text.ToLower());
        }

        private void BbuttonOnClick(object sender, EventArgs e)
        {
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            ChangeText(b.Text.ToLower());
        }

        private void VbuttonOnClick(object sender, EventArgs e)
        {
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            ChangeText(v.Text.ToLower());
        }

        private void CbuttonOnClick(object sender, EventArgs e)
        {
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            ChangeText(c.Text.ToLower());
        }

        private void XbuttonOnClick(object sender, EventArgs e)
        {
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            ChangeText(x.Text.ToLower());
        }

        private void ZbuttonOnClick(object sender, EventArgs e)
        {
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            ChangeText(z.Text.ToLower());
        }

        private void LbuttonOnClick(object sender, EventArgs e)
        {
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            ChangeText(l.Text.ToLower());
        }

        private void KbuttonOnClick(object sender, EventArgs e)
        {
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            ChangeText(k.Text.ToLower());
        }

        private void JbuttonOnClick(object sender, EventArgs e)
        {
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            ChangeText(j.Text.ToLower());
        }
        private void HbuttonOnClick(object sender, EventArgs e)
        {
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            ChangeText(h.Text.ToLower());
        }

        private void GbuttonOnClick(object sender, EventArgs e)
        {
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            ChangeText(g.Text.ToLower());
        }

        private void FbuttonOnClick(object sender, EventArgs e)
        {
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            ChangeText(f.Text.ToLower());
        }

        private void DbuttonOnClick(object sender, EventArgs e)
        {
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            ChangeText(d.Text.ToLower());
        }

        private void SbuttonOnClick(object sender, EventArgs e)
        {
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            ChangeText(s.Text.ToLower());
        }

        private void AbuttonOnClick(object sender, EventArgs e)
        {
            Button a = FindViewById<Button>(Resource.Id.abutton);
            ChangeText(a.Text.ToLower());
        }

        private void PbuttonOnClick(object sender, EventArgs e)
        {
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            ChangeText(p.Text.ToLower());
        }

        private void ObuttonOnClick(object sender, EventArgs e)
        {
            Button o = FindViewById<Button>(Resource.Id.obutton);
            ChangeText(o.Text.ToLower());
        }

        private void IbuttonOnClick(object sender, EventArgs e)
        {
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            ChangeText(i.Text.ToLower());
        }

        private void UbuttonOnClick(object sender, EventArgs e)
        {
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            ChangeText(u.Text.ToLower());
        }

        private void YbuttonOnClick(object sender, EventArgs e)
        {
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            ChangeText(y.Text.ToLower());
        }

        private void TbuttonOnClick(object sender, EventArgs e)
        {
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            ChangeText(t.Text.ToLower());
        }

        private void RbuttonOnClick(object sender, EventArgs e)
        {
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            ChangeText(r.Text.ToLower());
        }

        private void EbuttonOnClick(object sender, EventArgs e)
        {
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            ChangeText(_e.Text.ToLower());
        }

        private void WbuttonOnClick(object sender, EventArgs e)
        {
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            ChangeText(w.Text.ToLower());
        }

        private void QbuttonOnClick(object sender, EventArgs e)
        {
            //View view = (View)sender;
            //Snackbar.Make(view, "Q BUTTON CLICKED", Snackbar.LengthLong)
            //      .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            ChangeText(q.Text.ToLower());
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
            }
                txtWord.Text += letter;
                DoesSymbolExist(txtWord.Text);
            
        }

        private void SetButtonImageToSymbol(int resourceId)
        {
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetImageResource(resourceId);
            //imageButton.Visibility = ViewStates.Visible;
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
                image = name;
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public async Task SpeakNowDefaultSettings()
        {
            if (symbolClicked)
            {
                symbolClicked = false;
                await TextToSpeech.SpeakAsync(image);
            }
            else if (speechClicked)
            {
                speechClicked = false;
                TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
                string currentText = txtWord.Text;
                await TextToSpeech.SpeakAsync(currentText);
            }
            
        }


        //private void FabOnClick(object sender, EventArgs eventArgs)
        //{
        //    View view = (View) sender;
        //    Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
        //        .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        //}
    }
}

