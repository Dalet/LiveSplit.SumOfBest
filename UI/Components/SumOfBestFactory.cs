﻿using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class SumOfBestFactory : IComponentFactory
    {
        public string ComponentName => "Sum of Best";

        public string Description => "Displays the current sum of best segments.";

        public ComponentCategory Category => ComponentCategory.Information; 

        public IComponent Create(LiveSplitState state) => new SumOfBestComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.SumOfBest.xml";

        public string UpdateURL => "http://livesplit.org/update/";

        public Version Version => Version.Parse("1.6.3");
    }
}
