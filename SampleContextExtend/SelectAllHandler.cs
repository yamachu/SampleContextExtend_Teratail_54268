using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui;
using System;
using MonoDevelop.Ide.Editor.Extension;

namespace SampleContextExtend
{
	public class SelectAllHandler : CommandHandler
	{
		protected override void Run()
		{

		}

		protected override void Update(CommandInfo info)
		{
			info.Enabled = true;
		}
	}
}
