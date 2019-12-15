﻿using System.Threading;
using System.Windows.Forms;
using TagCloud.Models;

namespace TagCloud.Actions
{
    public class ShowImageAction : IAction
    {
        public string CommandName { get; } = "-showimage";

        public string Description { get; } = "display image";

        public void Perform(ClientConfig config, UserSettings settings)
        {
            if (!settings.CheckToComplete())
                return;
            var thread = new Thread(() =>
            {
                Application.EnableVisualStyles();
                var showImageForm = new ShowImageForm(config.ImageToSave);
                config.IsRunning = true;
                Application.Run(showImageForm);
            });
            thread.Start();
        }
    }
}