
// This file has been generated by the GUI designer. Do not modify.
namespace Comando
{
	public partial class WindowAddTab
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Entry _inputName;

		private global::Gtk.Label label1;

		private global::Gtk.Button _buttonAccept;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Comando.WindowAddTab
			this.Name = "Comando.WindowAddTab";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowAddTab");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Comando.WindowAddTab.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this._inputName = new global::Gtk.Entry();
			this._inputName.WidthRequest = 200;
			this._inputName.CanFocus = true;
			this._inputName.Name = "_inputName";
			this._inputName.IsEditable = true;
			this._inputName.InvisibleChar = '●';
			this.fixed1.Add(this._inputName);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this._inputName]));
			w1.X = 5;
			w1.Y = 40;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Tab name");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w2.X = 8;
			w2.Y = 19;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this._buttonAccept = new global::Gtk.Button();
			this._buttonAccept.WidthRequest = 100;
			this._buttonAccept.CanFocus = true;
			this._buttonAccept.Name = "_buttonAccept";
			this._buttonAccept.UseUnderline = true;
			this._buttonAccept.Label = global::Mono.Unix.Catalog.GetString("Accept");
			this.fixed1.Add(this._buttonAccept);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this._buttonAccept]));
			w3.X = 7;
			w3.Y = 72;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 220;
			this.DefaultHeight = 136;
			this.Show();
			this._buttonAccept.Clicked += new global::System.EventHandler(this.OnAcceptButtonClick);
		}
	}
}