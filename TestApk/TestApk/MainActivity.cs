using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Xamarin.Essentials;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using System.IO;
using Android.Graphics;

namespace TestApk
{
    [Activity(Theme = "@style/AppTheme.NoActionBar", MainLauncher = true,
                    ScreenOrientation = ScreenOrientation.Landscape)]

    public class MainActivity : AppCompatActivity
    {
        string image;
        bool symbolClicked;
        bool speechClicked;
        bool keyboardOptionsVisible = false;
        bool colourOptionsVisible = false;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            SetContentView(Resource.Layout.activity_main);

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
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.Click += LowbuttonOnClick;
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.Click += HighbuttonOnClick;
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.Click += ColourblindbuttonOnClick;
            Button colours = FindViewById<Button>(Resource.Id.coloursbutton);
            colours.Click += ColoursbuttonOnClick;
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.Click += NormalbuttonOnClick;
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.Click += ExtrabuttonOnClick;
        }

        private void NormalbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            txtWord.SetBackgroundColor(Color.White);
            txtWord.SetTextColor(Color.Black);
            RelativeLayout app = FindViewById<RelativeLayout>(Resource.Id.appLayout);
            app.SetBackgroundColor(Color.White);
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.SetBackgroundColor(Color.LightGray);
            q.SetTextColor(Color.Black);
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.SetBackgroundColor(Color.LightGray);
            w.SetTextColor(Color.Black);
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.SetBackgroundColor(Color.LightGray);
            _e.SetTextColor(Color.Black);
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.SetBackgroundColor(Color.LightGray);
            r.SetTextColor(Color.Black);
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.SetBackgroundColor(Color.LightGray);
            t.SetTextColor(Color.Black);
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.SetBackgroundColor(Color.LightGray);
            y.SetTextColor(Color.Black);
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.SetBackgroundColor(Color.LightGray);
            u.SetTextColor(Color.Black);
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.SetBackgroundColor(Color.LightGray);
            i.SetTextColor(Color.Black);
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.SetBackgroundColor(Color.LightGray);
            o.SetTextColor(Color.Black);
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.SetBackgroundColor(Color.LightGray);
            p.SetTextColor(Color.Black);
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.SetBackgroundColor(Color.LightGray);
            a.SetTextColor(Color.Black);
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.SetBackgroundColor(Color.LightGray);
            s.SetTextColor(Color.Black);
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.SetBackgroundColor(Color.LightGray);
            d.SetTextColor(Color.Black);
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.SetBackgroundColor(Color.LightGray);
            f.SetTextColor(Color.Black);
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.SetBackgroundColor(Color.LightGray);
            g.SetTextColor(Color.Black);
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.SetBackgroundColor(Color.LightGray);
            h.SetTextColor(Color.Black);
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.SetBackgroundColor(Color.LightGray);
            j.SetTextColor(Color.Black);
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.SetBackgroundColor(Color.LightGray);
            k.SetTextColor(Color.Black);
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.SetBackgroundColor(Color.LightGray);
            l.SetTextColor(Color.Black);
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.SetBackgroundColor(Color.LightGray);
            z.SetTextColor(Color.Black);
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.SetBackgroundColor(Color.LightGray);
            x.SetTextColor(Color.Black);
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.SetBackgroundColor(Color.LightGray);
            c.SetTextColor(Color.Black);
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.SetBackgroundColor(Color.LightGray);
            v.SetTextColor(Color.Black);
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.SetBackgroundColor(Color.LightGray);
            b.SetTextColor(Color.Black);
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.SetBackgroundColor(Color.LightGray);
            n.SetTextColor(Color.Black);
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.SetBackgroundColor(Color.LightGray);
            m.SetTextColor(Color.Black);
            Button del = FindViewById<Button>(Resource.Id.deletebutton);
            del.SetBackgroundColor(Color.LightGray);
            del.SetTextColor(Color.Black);
            Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            speak.SetBackgroundColor(Color.LightGray);
            speak.SetTextColor(Color.Black);
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.SetBackgroundColor(Color.LightGray);
            space.SetTextColor(Color.Black);
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetBackgroundColor(Color.LightGray);
            Button clear = FindViewById<Button>(Resource.Id.clearbutton);
            clear.SetBackgroundColor(Color.LightGray);
            clear.SetTextColor(Color.Black);
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.SetBackgroundColor(Color.LightGray);
            qwerty.SetTextColor(Color.Black);
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.SetBackgroundColor(Color.LightGray);
            alphabet.SetTextColor(Color.Black);
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.SetBackgroundColor(Color.LightGray);
            frequency.SetTextColor(Color.Black);
            Button keyboards = FindViewById<Button>(Resource.Id.keyboardsbutton);
            keyboards.SetBackgroundColor(Color.LightGray);
            keyboards.SetTextColor(Color.Black);
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.SetBackgroundColor(Color.LightGray);
            low.SetTextColor(Color.Black);
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.SetBackgroundColor(Color.LightGray);
            high.SetTextColor(Color.Black);
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.SetBackgroundColor(Color.LightGray);
            colourBlind.SetTextColor(Color.Black);
            Button colours = FindViewById<Button>(Resource.Id.coloursbutton);
            colours.SetBackgroundColor(Color.LightGray);
            colours.SetTextColor(Color.Black);
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.SetBackgroundColor(Color.LightGray);
            normal.SetTextColor(Color.Black);
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.SetBackgroundColor(Color.LightGray);
            extra.SetTextColor(Color.Black);
        }

        private void ColoursbuttonOnClick(object sender, EventArgs e)
        {
            if (!colourOptionsVisible)
            {
                colourOptionsVisible = true;
                Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
                colourBlind.Visibility = ViewStates.Visible;
                Button high = FindViewById<Button>(Resource.Id.highbutton);
                high.Visibility = ViewStates.Visible;
                Button low = FindViewById<Button>(Resource.Id.lowbutton);
                low.Visibility = ViewStates.Visible;
                Button normal = FindViewById<Button>(Resource.Id.normalbutton);
                normal.Visibility = ViewStates.Visible;

            }
            else
            {
                colourOptionsVisible = false;
                HideColourOptionsButtons();
            }
        }

        private void ColourblindbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            txtWord.SetBackgroundColor(Color.Yellow);
            txtWord.SetTextColor(Color.Black);
            RelativeLayout app = FindViewById<RelativeLayout>(Resource.Id.appLayout);
            app.SetBackgroundColor(Color.Black);
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.SetBackgroundColor(Color.Yellow);
            q.SetTextColor(Color.Black);
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.SetBackgroundColor(Color.Yellow);
            w.SetTextColor(Color.Black);
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.SetBackgroundColor(Color.Yellow);
            _e.SetTextColor(Color.Black);
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.SetBackgroundColor(Color.Yellow);
            r.SetTextColor(Color.Black);
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.SetBackgroundColor(Color.Yellow);
            t.SetTextColor(Color.Black);
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.SetBackgroundColor(Color.Yellow);
            y.SetTextColor(Color.Black);
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.SetBackgroundColor(Color.Yellow);
            u.SetTextColor(Color.Black);
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.SetBackgroundColor(Color.Yellow);
            i.SetTextColor(Color.Black);
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.SetBackgroundColor(Color.Yellow);
            o.SetTextColor(Color.Black);
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.SetBackgroundColor(Color.Yellow);
            p.SetTextColor(Color.Black);
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.SetBackgroundColor(Color.Yellow);
            a.SetTextColor(Color.Black);
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.SetBackgroundColor(Color.Yellow);
            s.SetTextColor(Color.Black);
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.SetBackgroundColor(Color.Yellow);
            d.SetTextColor(Color.Black);
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.SetBackgroundColor(Color.Yellow);
            f.SetTextColor(Color.Black);
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.SetBackgroundColor(Color.Yellow);
            g.SetTextColor(Color.Black);
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.SetBackgroundColor(Color.Yellow);
            h.SetTextColor(Color.Black);
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.SetBackgroundColor(Color.Yellow);
            j.SetTextColor(Color.Black);
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.SetBackgroundColor(Color.Yellow);
            k.SetTextColor(Color.Black);
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.SetBackgroundColor(Color.Yellow);
            l.SetTextColor(Color.Black);
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.SetBackgroundColor(Color.Yellow);
            z.SetTextColor(Color.Black);
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.SetBackgroundColor(Color.Yellow);
            x.SetTextColor(Color.Black);
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.SetBackgroundColor(Color.Yellow);
            c.SetTextColor(Color.Black);
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.SetBackgroundColor(Color.Yellow);
            v.SetTextColor(Color.Black);
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.SetBackgroundColor(Color.Yellow);
            b.SetTextColor(Color.Black);
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.SetBackgroundColor(Color.Yellow);
            n.SetTextColor(Color.Black);
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.SetBackgroundColor(Color.Yellow);
            m.SetTextColor(Color.Black);
            Button del = FindViewById<Button>(Resource.Id.deletebutton);
            del.SetBackgroundColor(Color.Yellow);
            del.SetTextColor(Color.Black);
            Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            speak.SetBackgroundColor(Color.Yellow);
            speak.SetTextColor(Color.Black);
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.SetBackgroundColor(Color.Yellow);
            space.SetTextColor(Color.Black);
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetBackgroundColor(Color.Yellow);
            Button clear = FindViewById<Button>(Resource.Id.clearbutton);
            clear.SetBackgroundColor(Color.Yellow);
            clear.SetTextColor(Color.Black);
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.SetBackgroundColor(Color.Yellow);
            qwerty.SetTextColor(Color.Black);
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.SetBackgroundColor(Color.Yellow);
            alphabet.SetTextColor(Color.Black);
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.SetBackgroundColor(Color.Yellow);
            frequency.SetTextColor(Color.Black);
            Button keyboards = FindViewById<Button>(Resource.Id.keyboardsbutton);
            keyboards.SetBackgroundColor(Color.Yellow);
            keyboards.SetTextColor(Color.Black);
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.SetBackgroundColor(Color.Yellow);
            low.SetTextColor(Color.Black);
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.SetBackgroundColor(Color.Yellow);
            high.SetTextColor(Color.Black);
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.SetBackgroundColor(Color.Yellow);
            colourBlind.SetTextColor(Color.Black);
            Button colours = FindViewById<Button>(Resource.Id.coloursbutton);
            colours.SetBackgroundColor(Color.Yellow);
            colours.SetTextColor(Color.Black);
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.SetBackgroundColor(Color.Yellow);
            normal.SetTextColor(Color.Black);
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.SetBackgroundColor(Color.Yellow);
            extra.SetTextColor(Color.Black);
        }

        private void HighbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            txtWord.SetBackgroundColor(Color.White);
            txtWord.SetTextColor(Color.Black);
            RelativeLayout app = FindViewById<RelativeLayout>(Resource.Id.appLayout);
            app.SetBackgroundColor(Color.Black);
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.SetBackgroundColor(Color.White);
            q.SetTextColor(Color.Black);
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.SetBackgroundColor(Color.White);
            w.SetTextColor(Color.Black);
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.SetBackgroundColor(Color.White);
            _e.SetTextColor(Color.Black);
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.SetBackgroundColor(Color.White);
            r.SetTextColor(Color.Black);
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.SetBackgroundColor(Color.White);
            t.SetTextColor(Color.Black);
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.SetBackgroundColor(Color.White);
            y.SetTextColor(Color.Black);
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.SetBackgroundColor(Color.White);
            u.SetTextColor(Color.Black);
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.SetBackgroundColor(Color.White);
            i.SetTextColor(Color.Black);
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.SetBackgroundColor(Color.White);
            o.SetTextColor(Color.Black);
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.SetBackgroundColor(Color.White);
            p.SetTextColor(Color.Black);
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.SetBackgroundColor(Color.White);
            a.SetTextColor(Color.Black);
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.SetBackgroundColor(Color.White);
            s.SetTextColor(Color.Black);
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.SetBackgroundColor(Color.White);
            d.SetTextColor(Color.Black);
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.SetBackgroundColor(Color.White);
            f.SetTextColor(Color.Black);
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.SetBackgroundColor(Color.White);
            g.SetTextColor(Color.Black);
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.SetBackgroundColor(Color.White);
            h.SetTextColor(Color.Black);
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.SetBackgroundColor(Color.White);
            j.SetTextColor(Color.Black);
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.SetBackgroundColor(Color.White);
            k.SetTextColor(Color.Black);
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.SetBackgroundColor(Color.White);
            l.SetTextColor(Color.Black);
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.SetBackgroundColor(Color.White);
            z.SetTextColor(Color.Black);
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.SetBackgroundColor(Color.White);
            x.SetTextColor(Color.Black);
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.SetBackgroundColor(Color.White);
            c.SetTextColor(Color.Black);
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.SetBackgroundColor(Color.White);
            v.SetTextColor(Color.Black);
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.SetBackgroundColor(Color.White);
            b.SetTextColor(Color.Black);
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.SetBackgroundColor(Color.White);
            n.SetTextColor(Color.Black);
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.SetBackgroundColor(Color.White);
            m.SetTextColor(Color.Black);
            Button del = FindViewById<Button>(Resource.Id.deletebutton);
            del.SetBackgroundColor(Color.White);
            del.SetTextColor(Color.Black);
            Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            speak.SetBackgroundColor(Color.White);
            speak.SetTextColor(Color.Black);
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.SetBackgroundColor(Color.White);
            space.SetTextColor(Color.Black);
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetBackgroundColor(Color.White);
            Button clear = FindViewById<Button>(Resource.Id.clearbutton);
            clear.SetBackgroundColor(Color.White);
            clear.SetTextColor(Color.Black);
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.SetBackgroundColor(Color.White);
            qwerty.SetTextColor(Color.Black);
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.SetBackgroundColor(Color.White);
            alphabet.SetTextColor(Color.Black);
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.SetBackgroundColor(Color.White);
            frequency.SetTextColor(Color.Black);
            Button keyboards = FindViewById<Button>(Resource.Id.keyboardsbutton);
            keyboards.SetBackgroundColor(Color.White);
            keyboards.SetTextColor(Color.Black);
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.SetBackgroundColor(Color.White);
            low.SetTextColor(Color.Black);
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.SetBackgroundColor(Color.White);
            high.SetTextColor(Color.Black);
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.SetBackgroundColor(Color.White);
            colourBlind.SetTextColor(Color.Black);
            Button colours = FindViewById<Button>(Resource.Id.coloursbutton);
            colours.SetBackgroundColor(Color.White);
            colours.SetTextColor(Color.Black);
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.SetBackgroundColor(Color.White);
            normal.SetTextColor(Color.Black);
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.SetBackgroundColor(Color.White);
            extra.SetTextColor(Color.Black);
        }

        private void LowbuttonOnClick(object sender, EventArgs e)
        {
            TextView txtWord = FindViewById<TextView>(Resource.Id.txtWord);
            txtWord.SetBackgroundColor(Color.Black);
            txtWord.SetTextColor(Color.White);
            RelativeLayout app = FindViewById<RelativeLayout>(Resource.Id.appLayout);
            app.SetBackgroundColor(Color.White);
            Button q = FindViewById<Button>(Resource.Id.qbutton);
            q.SetBackgroundColor(Color.Black);
            q.SetTextColor(Color.Black);
            Button w = FindViewById<Button>(Resource.Id.wbutton);
            w.SetBackgroundColor(Color.Black);
            w.SetTextColor(Color.White);
            Button _e = FindViewById<Button>(Resource.Id.ebutton);
            _e.SetBackgroundColor(Color.Black);
            _e.SetTextColor(Color.White);
            Button r = FindViewById<Button>(Resource.Id.rbutton);
            r.SetBackgroundColor(Color.Black);
            r.SetTextColor(Color.White);
            Button t = FindViewById<Button>(Resource.Id.tbutton);
            t.SetBackgroundColor(Color.Black);
            t.SetTextColor(Color.White);
            Button y = FindViewById<Button>(Resource.Id.ybutton);
            y.SetBackgroundColor(Color.Black);
            y.SetTextColor(Color.White);
            Button u = FindViewById<Button>(Resource.Id.ubutton);
            u.SetBackgroundColor(Color.Black);
            u.SetTextColor(Color.White);
            Button i = FindViewById<Button>(Resource.Id.ibutton);
            i.SetBackgroundColor(Color.Black);
            i.SetTextColor(Color.White);
            Button o = FindViewById<Button>(Resource.Id.obutton);
            o.SetBackgroundColor(Color.Black);
            o.SetTextColor(Color.White);
            Button p = FindViewById<Button>(Resource.Id.pbutton);
            p.SetBackgroundColor(Color.Black);
            p.SetTextColor(Color.White);
            Button a = FindViewById<Button>(Resource.Id.abutton);
            a.SetBackgroundColor(Color.Black);
            a.SetTextColor(Color.White);
            Button s = FindViewById<Button>(Resource.Id.sbutton);
            s.SetBackgroundColor(Color.Black);
            s.SetTextColor(Color.White);
            Button d = FindViewById<Button>(Resource.Id.dbutton);
            d.SetBackgroundColor(Color.Black);
            d.SetTextColor(Color.White);
            Button f = FindViewById<Button>(Resource.Id.fbutton);
            f.SetBackgroundColor(Color.Black);
            f.SetTextColor(Color.White);
            Button g = FindViewById<Button>(Resource.Id.gbutton);
            g.SetBackgroundColor(Color.Black);
            g.SetTextColor(Color.White);
            Button h = FindViewById<Button>(Resource.Id.hbutton);
            h.SetBackgroundColor(Color.Black);
            h.SetTextColor(Color.White);
            Button j = FindViewById<Button>(Resource.Id.jbutton);
            j.SetBackgroundColor(Color.Black);
            j.SetTextColor(Color.White);
            Button k = FindViewById<Button>(Resource.Id.kbutton);
            k.SetBackgroundColor(Color.Black);
            k.SetTextColor(Color.White);
            Button l = FindViewById<Button>(Resource.Id.lbutton);
            l.SetBackgroundColor(Color.Black);
            l.SetTextColor(Color.White);
            Button z = FindViewById<Button>(Resource.Id.zbutton);
            z.SetBackgroundColor(Color.Black);
            z.SetTextColor(Color.White);
            Button x = FindViewById<Button>(Resource.Id.xbutton);
            x.SetBackgroundColor(Color.Black);
            x.SetTextColor(Color.White);
            Button c = FindViewById<Button>(Resource.Id.cbutton);
            c.SetBackgroundColor(Color.Black);
            c.SetTextColor(Color.White);
            Button v = FindViewById<Button>(Resource.Id.vbutton);
            v.SetBackgroundColor(Color.Black);
            v.SetTextColor(Color.White);
            Button b = FindViewById<Button>(Resource.Id.bbutton);
            b.SetBackgroundColor(Color.Black);
            b.SetTextColor(Color.White);
            Button n = FindViewById<Button>(Resource.Id.nbutton);
            n.SetBackgroundColor(Color.Black);
            n.SetTextColor(Color.White);
            Button m = FindViewById<Button>(Resource.Id.mbutton);
            m.SetBackgroundColor(Color.Black);
            m.SetTextColor(Color.White);
            Button del = FindViewById<Button>(Resource.Id.deletebutton);
            del.SetBackgroundColor(Color.Black);
            del.SetTextColor(Color.White);
            Button speak = FindViewById<Button>(Resource.Id.speakbutton);
            speak.SetBackgroundColor(Color.Black);
            speak.SetTextColor(Color.White);
            Button space = FindViewById<Button>(Resource.Id.spacebutton);
            space.SetBackgroundColor(Color.Black);
            space.SetTextColor(Color.White);
            ImageButton imageButton = FindViewById<ImageButton>(Resource.Id.imagebutton);
            imageButton.SetBackgroundColor(Color.Black);
            Button clear = FindViewById<Button>(Resource.Id.clearbutton);
            clear.SetBackgroundColor(Color.Black);
            clear.SetTextColor(Color.White);
            Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
            qwerty.SetBackgroundColor(Color.Black);
            qwerty.SetTextColor(Color.White);
            Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
            alphabet.SetBackgroundColor(Color.Black);
            alphabet.SetTextColor(Color.White);
            Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
            frequency.SetBackgroundColor(Color.Black);
            frequency.SetTextColor(Color.White);
            Button keyboards = FindViewById<Button>(Resource.Id.keyboardsbutton);
            keyboards.SetBackgroundColor(Color.Black);
            keyboards.SetTextColor(Color.White);
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.SetBackgroundColor(Color.Black);
            low.SetTextColor(Color.White);
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.SetBackgroundColor(Color.Black);
            high.SetTextColor(Color.White);
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.SetBackgroundColor(Color.Black);
            colourBlind.SetTextColor(Color.White);
            Button colours = FindViewById<Button>(Resource.Id.coloursbutton);
            colours.SetBackgroundColor(Color.Black);
            colours.SetTextColor(Color.White);
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.SetBackgroundColor(Color.Black);
            normal.SetTextColor(Color.White);
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            extra.SetBackgroundColor(Color.Black);
            extra.SetTextColor(Color.White);
        }

        private void KeyboardsbuttonOnClick(object sender, EventArgs e)
        {
            if (!keyboardOptionsVisible)
            {
                keyboardOptionsVisible = true;
                Button frequency = FindViewById<Button>(Resource.Id.frequencybutton);
                frequency.Visibility = ViewStates.Visible;
                Button alphabet = FindViewById<Button>(Resource.Id.alphabetbutton);
                alphabet.Visibility = ViewStates.Visible;
                Button qwerty = FindViewById<Button>(Resource.Id.qwertybutton);
                qwerty.Visibility = ViewStates.Visible;
            }
            else
            {
                keyboardOptionsVisible = false;
                HideKeyboardOptionsButtons();
            }
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
            HideKeyboardOptionsButtons();

        }

        private void HideColourOptionsButtons()
        {
            Button low = FindViewById<Button>(Resource.Id.lowbutton);
            low.Visibility = ViewStates.Invisible;
            Button high = FindViewById<Button>(Resource.Id.highbutton);
            high.Visibility = ViewStates.Invisible;
            Button colourBlind = FindViewById<Button>(Resource.Id.colourblindbutton);
            colourBlind.Visibility = ViewStates.Invisible;
            Button normal = FindViewById<Button>(Resource.Id.normalbutton);
            normal.Visibility = ViewStates.Invisible;
        }

        private void HideKeyboardOptionsButtons()
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
            HideKeyboardOptionsButtons();
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
            HideKeyboardOptionsButtons();
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

        private void ExtrabuttonOnClick(object sender, EventArgs e)
        {
            Button extra = FindViewById<Button>(Resource.Id.extrabutton);
            ChangeText(extra.Text.ToLower());
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
            imageButton.Visibility = ViewStates.Visible;
        }

        public void DoesSymbolExist(string symbol)
        {
            var context = Android.App.Application.Context;
            var resources = context.Resources;
            var name = System.IO.Path.GetFileNameWithoutExtension(symbol);
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
    }
}

