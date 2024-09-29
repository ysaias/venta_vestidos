﻿namespace begywebsapi.DTOs
{
    public class PagoDto
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public DateTime FechaDePago { get; set; }
        public string MetodoDePago { get; set; } = null!;
        public decimal MontoDePago { get; set; }
    }

}
