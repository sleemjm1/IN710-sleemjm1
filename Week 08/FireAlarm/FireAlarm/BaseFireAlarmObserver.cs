﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class BaseFireAlarmObserver
    {
        protected FireAlarmSubject subject;

        public BaseFireAlarmObserver(FireAlarmSubject subject)
        {
            this.subject = subject;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);

            subject.FireEvent += handler;
        }

        public abstract void FireAlarmHandlerMethod(object fireSubject, FireAlarmEventArgs fe);
  
    }
}
