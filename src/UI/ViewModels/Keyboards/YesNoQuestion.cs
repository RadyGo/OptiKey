﻿using System;
using JuliusSweetland.OptiKey.UI.ViewModels.Keyboards.Base;
using log4net;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Keyboards
{
    public class YesNoQuestion : Keyboard
    {
        private readonly static ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly string text;
        private readonly Action yesAction;
        private readonly Action noAction;

        public YesNoQuestion(
            string text,
            Action yesAction,
            Action noAction)
        {
            this.text = text;

            this.yesAction = () =>
            {
                Log.Debug("Triggering YES action.");
                yesAction();
            };

            this.noAction = () =>
            {
                Log.Debug("Triggering NO action.");
                noAction();
            };
        }
        
        public string Text { get { return text; } }
        public Action YesAction { get { return yesAction; } }
        public Action NoAction { get { return noAction; } }
    }
}
