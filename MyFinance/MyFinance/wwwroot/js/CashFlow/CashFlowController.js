

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
                    '<button type="button" class="btn btn-link waves-effect" data-dismiss="modal" id="confirmed_btn">Yes</button>'+
                '</div>'+
            '</div>'+
    '</div >'+
'</div >');
        $('#confirmed_btn').on("click", function (/*evt*/) {
            
            
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
                //,
                //success: function (response) {

                //    $('#resultIdDiv').show();
                //    $('#resultIdDiv').innerHTML = data;
                //     $('#resultIdDiv').show();
                //    $(document).ready(function () {
                //    alert(" sucesso");
                //    debugger;
                //    $('#resultIdDiv').load('@Url.Action("GetAllDespesas", "CashFlow")')
                //    evt.preventDefault();
                //    evt.stopPropagation();
                //        url = $(this).data('url');
                //    $.get(url, function (data) {
                //    $('#resultIdDiv').replaceWith(data);
                //    });

                //    });
                //},
                //error: function (response) {
                //    alert(response + " erro");
                //     $('#resultIdDiv').show();
                //    $('#resultIdDiv').innerHTML = data;
                //    alert(response + " erro!");
                //    debugger;
                //     $('#resultIdDiv').load('@Url.Action("GetAllDespesas", "CashFlow")')
                //    evt.preventDefault();
                //    evt.stopPropagation();
                    
                //        url = $(this).data('url');
                //    $.get(url, function (data) {
                //        $('#resultIdDiv').load(data);
                //    });
                   


                //}
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
            //,
            //success: function (response) {

            //    //$('#resultIdDiv').show();
            //    //$('#resultIdDiv').innerHTML = data;
            //    /* $('#resultIdDiv').show();*/
            //    //$(document).ready(function () {
            //    alert(response);

            //    //});
            //},
            //error: function (response) {
            //    //alert(response + " erro");
            //    /* $('#resultIdDiv').show();*/
            //    //$('#resultIdDiv').innerHTML = data;
            //    alert(response + " erro!")

            //}
        });
    }
});


