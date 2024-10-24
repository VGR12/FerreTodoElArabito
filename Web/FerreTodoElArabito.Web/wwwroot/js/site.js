
$("body").on("click", "[data-enviogenerico]", function (e) {
    e.preventDefault();
    var formulario = $(this).closest("form");
    var ruta = formulario.attr("action");
    var datosFormulario = {};
    var tbody = $("[data-resultados]");
    if (tbody == undefined) {
        return;
    }

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

            if (response.status === "OK") {

                tbody.html('');


                if (response.data != undefined) {
                    if (response.data.lenght > 0) {

                        location.href = response.data.url;

                        //$.each(response.data, function (index, value) {


                        //    console.log('Índice: ' + index + ', Valor: ' + value);
                        //});

                    } else {
                        var subtitulos = $('th').length;
                        const row = document.createElement('tr');
                        const mensaje = document.createElement('td');
                        mensaje.setAttribute('colspan', subtitulos);
                        mensaje.textContent = "No se encontraron resultados";
                        mensaje.style.textAlign = "center";
                        row.appendChild(mensaje);
                        tbody.html(row);
                    }

                } else {
                    var subtitulos = $('th').length;
                    const row = document.createElement('tr');
                    const mensaje = document.createElement('td');
                    mensaje.setAttribute('colspan', subtitulos);
                    mensaje.textContent = "Ha ocurrido un error al obtener los resultados";
                    mensaje.style.textAlign = "center";
                    row.appendChild(mensaje);
                    tbody.html(row);
                }


            } else {

            }



            console.log("Respuesta del servidor:", response);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log("Error en la petición:", textStatus, errorThrown);
        }
    });


});