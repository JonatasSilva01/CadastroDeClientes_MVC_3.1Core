// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Verifica os estados
jQuery(function ($) {
    $("input[name='cep']").change(function () {
        var cep_code = $(this).val();
        if (cep_code.length <= 0) return;
        $.get("https://apps.widenet.com.br/busca-cep/api/cep.json", { code: cep_code }, function (result) {
            if (result.status != "200") {
                alert(result.message || "cep não encontrado!");
                return;
            }
            $("input[name='cep']").val(result.code);
            $("input[name='estado']").val(result.state);
            $("input[name='cidade']").val(result.city);
            $("input[name='bairro']").val(result.district);
            $("input[name='endereco']").val(result.address);
        });
    });
});