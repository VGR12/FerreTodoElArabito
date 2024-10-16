
$("body").on("click", "[data-enviogenerico]", function (e) {
    e.preventDefault();
    var formulario = $(this).closest("form");
    var ruta = formulario.attr("action");
    var datosFormulario = {};

    formulario.find("input").each(function () {
        var id = $(this).attr("id");
        if (id) {
            var nombre = $(this).attr("name");
            var valor = $(this).val();
            datosFormulario[nombre] = valor;
        }
    });

    $.ajax({
        url: ruta,
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(datosFormulario),
        success: function (response) {
            console.log("Respuesta del servidor:", response);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Error en la petición:", textStatus, errorThrown);
        }
    });


});