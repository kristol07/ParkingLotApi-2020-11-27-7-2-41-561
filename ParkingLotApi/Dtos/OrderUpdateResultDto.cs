﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingLotApi.Entities;

namespace ParkingLotApi.Dtos
{
    public class OrderUpdateResultDto
    {
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Close;
    }
}
