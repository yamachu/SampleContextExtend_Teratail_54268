using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using System;

namespace SampleContextExtend
{
	public class SelectAllHandler : CommandHandler
	{
		protected override void Run()
		{

		}

		protected override void Update(CommandInfo info)
		{
			info.Visible = true;
			info.Enabled = true;
		}
	}
}
