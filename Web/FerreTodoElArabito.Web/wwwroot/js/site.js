
$("body").on("click", "[data-enviogenerico]", function () {

    var formulario = $(this).closest("form");
    var ruta = formulario.attr("action");
    var datosFormulario = {};

    formulario.find("input").each(function () {
        var nombre = $(this).attr("name");
        var valor = $(this).val();
        datosFormulario[nombre] = valor;
    });

    console.log(datosFormulario);

    $.ajax({
        url: ruta,
        type: 'POST',
        data: datosFormulario,
        success: function (response) {
            console.log("Respuesta del servidor:", response);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Error en la petición:", textStatus, errorThrown);
        }
    });


});