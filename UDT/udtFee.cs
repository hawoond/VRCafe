using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRTimer.UDT
{
    public class udtFeeOption
    {
        /// <summary>
        /// 기간제 요금
        /// </summary>
        public int FixedRate
        {
            get;
            set;
        }

        /// <summary>
        /// 시간제 요금(30분)
        /// </summary>
        public int HourlyRateHalf
        {
            get;
            set;
        }

        /// <summary>
        /// 시간제 요금(한시간)
        /// </summary>
        public int HourlyRateHour
        {
            get;
            set;
        }

        /// <summary>
        /// 최초 초기화를 위한 생성장
        /// </summary>
        /// <param name="fixedFee"></param>
        /// <param name="hourlyRateHalf"></param>
        /// <param name="hourlyRateHour"></param>
        public udtFeeOption(int fixedFee, int hourlyRateHalf, int hourlyRateHour)
        {
            this.FixedRate = fixedFee;
            this.HourlyRateHalf = hourlyRateHalf;
            this.HourlyRateHour = hourlyRateHour;
        }
    }
}