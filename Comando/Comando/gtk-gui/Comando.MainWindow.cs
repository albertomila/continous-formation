
// This file has been generated by the GUI designer. Do not modify.
namespace Comando
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action preferencesAction;

		private global::Gtk.Action executeAction;

		private global::Gtk.Action networkAction;

		private global::Gtk.Action saveAction;

		private global::Gtk.Action goForwardAction;

		private global::Gtk.Action goBackAction;

		private global::Gtk.VBox vbox1;

		private global::Gtk.MenuBar menubar1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Notebook notebook1;

		private global::Comando.WidgetConsole _widgetconsole;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Comando.MainWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.preferencesAction = new global::Gtk.Action("preferencesAction", global::Mono.Unix.Catalog.GetString("Tools"), null, "gtk-preferences");
			this.preferencesAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Tools");
			w1.Add(this.preferencesAction, null);
			this.executeAction = new global::Gtk.Action("executeAction", global::Mono.Unix.Catalog.GetString("Configuration"), null, "gtk-execute");
			this.executeAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Configuration");
			this.executeAction.Visible = false;
			w1.Add(this.executeAction, null);
			this.networkAction = new global::Gtk.Action("networkAction", global::Mono.Unix.Catalog.GetString("Add host target"), null, "gtk-network");
			this.networkAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Add host target");
			w1.Add(this.networkAction, null);
			this.saveAction = new global::Gtk.Action("saveAction", global::Mono.Unix.Catalog.GetString("Save"), null, "gtk-save");
			this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Save");
			w1.Add(this.saveAction, null);
			this.goForwardAction = new global::Gtk.Action("goForwardAction", global::Mono.Unix.Catalog.GetString("Export commands"), null, "gtk-go-forward");
			this.goForwardAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Export commands");
			w1.Add(this.goForwardAction, null);
			this.goBackAction = new global::Gtk.Action("goBackAction", global::Mono.Unix.Catalog.GetString("Import commands"), null, "gtk-go-back");
			this.goBackAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Import commands");
			w1.Add(this.goBackAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "Comando.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Comando.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString(@"<ui><menubar name='menubar1'><menu name='preferencesAction' action='preferencesAction'><menuitem name='executeAction' action='executeAction'/><menuitem name='networkAction' action='networkAction'/><menuitem name='goForwardAction' action='goForwardAction'/><menuitem name='goBackAction' action='goBackAction'/><menuitem name='saveAction' action='saveAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add(this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.WidthRequest = 850;
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.hbox1.Add(this.notebook1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.notebook1]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this._widgetconsole = new global::Comando.WidgetConsole();
			this._widgetconsole.WidthRequest = 500;
			this._widgetconsole.Events = ((global::Gdk.EventMask)(256));
			this._widgetconsole.Name = "_widgetconsole";
			this.hbox1.Add(this._widgetconsole);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this._widgetconsole]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w5.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 1356;
			this.DefaultHeight = 750;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.executeAction.Activated += new global::System.EventHandler(this.OnMenuConfigurationButtonPress);
			this.networkAction.Activated += new global::System.EventHandler(this.OnMenuAddHostTargetButtonPress);
			this.saveAction.Activated += new global::System.EventHandler(this.OnMenuSaveButtonClick);
			this.goForwardAction.Activated += new global::System.EventHandler(this.OnExportCommandsButtonPress);
			this.goBackAction.Activated += new global::System.EventHandler(this.OnImportCommandsButtonPress);
		}
	}
}