using System.ComponentModel.DataAnnotations;

namespace AluguelCarros.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

