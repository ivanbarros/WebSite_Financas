

$('#buttonSearch').on("click", function () {
    if ($('#CategoryTypeId').val() === '' && $('#CashFlowTypeId').val() === '') {
        debugger;
        $('#modalResult').append('<div class="modal fade" id="mdModal" tabindex="-1" role="dialog" aria-labelledby="defaultModalLabel" aria-hidden="true">' +
            '< div class= "modal-dialog" role = "document" > <div class="modal-content modal-col-teal">' +
                '<div class="modal-header">' +
                    '<h5 class="modal-title" id="defaultModalLabel">Aviso</h5>'+
                    '<button type="button" class="close" data-dismiss="modal" aria-label="Close">'+
                        '<span aria-hidden="true">&times;</span>'+
                    '</button>'+
                '</div>'+
                '<div class="modal-body">'+
                    'Você não selecionou nenhuma categoria ou tipo, deseja continuar?'+
                '</div>'+
                '<div class="modal-footer">'+
                    '<button type="button" class="btn btn-link waves-effect" data-dismiss="modal">Cancel</button>'+
                    '<button type="button" class="btn btn-link waves-effect" id="confirmed_btn">Yes</button>'+
                '</div>'+
            '</div>'+
    '</div >'+
'</div >');
        $('#confirmed_btn').on("click", function (evt) {

            evt.preventDefault();
            evt.stopPropagation();
            var $detailsDivResult = $('#resultIdDiv'),
                url = $(this).data('url');
            $.get(url, function (data) {
                $detailsDivResult.replaceWith(data);
            });
            $.ajax({
                url: '/CashFlow/GetAllDespesas',
                dataType: "json",
                type: "post",
                cache: false,
                async: false,
                data: {
                    categoryName: $('#CategoryTypeId').val(),
                    decision: $('#CashFlowTypeId').val()
                }
                ,
                success: function (response) {

                    //$('#resultIdDiv').show();
                    //$('#resultIdDiv').innerHTML = data;
                    /* $('#resultIdDiv').show();*/
                    //$(document).ready(function () {
                    alert("sucesso");
                    $('#resultIdDiv').load('@Url.Action("GetAllDespesas", "CashFlow")')

                    //});
                },
                error: function (response) {
                    //alert(response + " erro");
                    /* $('#resultIdDiv').show();*/
                    //$('#resultIdDiv').innerHTML = data;
                    alert("erro!");
                    $('#resultIdDiv').load('@Url.Action("GetAllDespesas", "CashFlow")')

                }
            });
        });
    }

    else {

        $.ajax({
            url: '/CashFlow/GetDespesaReceita',
            dataType: "json",
            type: "post",
            cache: false,
            async: false,
            data: {
                categoryName: $('#CategoryTypeId').val(),
                decision: $('#CashFlowTypeId').val()
            }
            ,
            success: function (response) {

                //$('#resultIdDiv').show();
                //$('#resultIdDiv').innerHTML = data;
                /* $('#resultIdDiv').show();*/
                //$(document).ready(function () {
                alert(response);

                //});
            },
            error: function (response) {
                //alert(response + " erro");
                /* $('#resultIdDiv').show();*/
                //$('#resultIdDiv').innerHTML = data;
                alert(response + " erro!")

            }
        });
    }
});


