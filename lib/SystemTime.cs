using System;

using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace WmAutoUpdate
{
  [StructLayout(LayoutKind.Sequential)]

  public struct SystemTime
  {

    public short m_year;

    public short m_month;

    public short m_dayOfWeek;

    public short m_day;

    public short m_hour;

    public short m_minute;

    public short m_second;

    public short m_milliseconds;

    public SystemTime(DateTime value)
    {

      m_year = (Int16)value.Year;

      m_month = (Int16)value.Month;

      m_dayOfWeek = (Int16)value.DayOfWeek;

      m_day = (Int16)value.Day;

      m_hour = (Int16)value.Hour;

      m_minute = (Int16)value.Minute;

      m_second = (Int16)value.Second;

      m_milliseconds = (Int16)value.Millisecond;

    }

  }
}
