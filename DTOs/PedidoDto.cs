﻿namespace begywebsapi.DTOs
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public List<PedidoItemDto> PedidoItems { get; set; } = new List<PedidoItemDto>();
        public List<PagoDto> Pagos { get; set; } = new List<PagoDto>();
    }
}
