using System;

namespace OpenTK.Sample
{
	public class DemoListConroller : UIViewController
	{
		public DemoListConroller()
		{
		}

        public override void LoadView()
        {
            base.LoadView();
            View.BackgroundColor = UIColor.White;

            var btn1 = new UIButton(UIButtonType.System);
            btn1.SetTitle("OpenGLESSample (OpenGLES1)", UIControlState.Normal);

            btn1.TouchUpInside += Btn1_TouchUpInside;
            btn1.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddSubview(btn1);

            btn1.TopAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.TopAnchor).Active = true;
            btn1.CenterXAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.CenterXAnchor).Active = true;


            var btn2 = new UIButton(UIButtonType.System);
            btn2.SetTitle("GLKBaseEffectDrawing (OpenGLES2)", UIControlState.Normal);

            btn2.TouchUpInside += Btn2_TouchUpInside;
            btn2.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddSubview(btn2);

            btn2.TopAnchor.ConstraintEqualTo(btn1.BottomAnchor, 10).Active = true;
            btn2.CenterXAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.CenterXAnchor).Active = true;


            var btn3 = new UIButton(UIButtonType.System);
            btn3.SetTitle("OpenGLES20Example", UIControlState.Normal);

            btn3.TouchUpInside += Btn3_TouchUpInside;
            btn3.TranslatesAutoresizingMaskIntoConstraints = false;
            View.AddSubview(btn3);

            btn3.TopAnchor.ConstraintEqualTo(btn2.BottomAnchor, 10).Active = true;
            btn3.CenterXAnchor.ConstraintEqualTo(View.SafeAreaLayoutGuide.CenterXAnchor).Active = true;

        }

        private void Btn1_TouchUpInside(object sender, EventArgs e)
        {
            var vc = new UIViewController();

            var view = new EAGLView();
            view.TranslatesAutoresizingMaskIntoConstraints = false;

            vc.View!.AddSubview(view);
            view.TopAnchor.ConstraintEqualTo(vc.View.SafeAreaLayoutGuide.TopAnchor).Active = true;
            view.LeadingAnchor.ConstraintEqualTo(vc.View.SafeAreaLayoutGuide.LeadingAnchor).Active = true;
            view.TrailingAnchor.ConstraintEqualTo(vc.View.SafeAreaLayoutGuide.TrailingAnchor).Active = true;
            view.BottomAnchor.ConstraintEqualTo(vc.View.SafeAreaLayoutGuide.BottomAnchor).Active = true;

            PresentViewController(vc, true, null);
        }

        private void Btn2_TouchUpInside(object sender, EventArgs e)
        {
		    var vc = new MCViewController();
            PresentViewController(vc, true, null);
        }

        private void Btn3_TouchUpInside(object sender, EventArgs e)
        {
            var vc = new GLViewController();

            PresentViewController(vc, true, () => {
                (vc.View as GLView).StartAnimation();
            });
        }
    }
}

