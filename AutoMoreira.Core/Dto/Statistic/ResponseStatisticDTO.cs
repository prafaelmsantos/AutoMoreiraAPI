﻿namespace AutoMoreira.Core.Dto.Statistic
{
    public class ResponseStatisticDTO
    {
        public List<StatisticDTO> Statistics { get; set; } = new();
        public double Value { get; set; }
        public double ValuePerc { get; set; }
    }
}
