getDespesaReceita();
$('#editButton').on("click", function () {

    EditarPlanoConta(id);
});

$('#buttonSearch').on("click", function () {

    getDespesaReceita();

    $('#CategoryTypeId').removeData($('#CategoryTypeId').val);
    $('#CashFlowTypeId').removeData($('#CashFlowTypeId').val);
});


function getDespesaReceita() {
    $('#resultDespesaSelectedDiv').load("/CashFlow/GetDespesaReceita?categoryName=" + $('#CategoryTypeId').val() + "&decision=" + $('#CashFlowTypeId').val());
    //$.ajax({
    //    type: "POST",
    //    url: "/CashFlow/GetDespesaReceita?categoryName=" + $('#CategoryTypeId').val() + "&decision=" + $('#CashFlowTypeId').val(),
    //    contentType: "application/json; charset=utf-8",
    //    dataType: "json"
    //});
};

function DetalhePlanoConta(id) {
    $('#renderEditView').load("/CashFlow/Detalhes?id=" + id);
};

//function ExcluirConta() {
//        //window.location.href = "/CashFlow/Excluir/" + id;
//        alert($(".inputHidenDelete").val());
//        }
function ExcluirConta(id_conta) {

    $("#DeleteModal").prepend('<div class="modal fade" id="DeleteConfirmation" tabindex="-1" role="dialog" aria-labelledby="defaultModalLabel" aria-hidden="true">'
        + '<div class= "modal-dialog" role = "document">'
        +'<div class= "modal-content modal-col-red">'
            +'<div class="modal-header">'
              +  '<h1 class="modal-title" id="DeleteModalLabel">AVISO!!!</h1>'
          +  '</div>'
        + '<div class="modal-body">'
        + '<h3> Você tem certeza que deseja excluir esse item?</h3>'          
            + '<div class="modal-footer">'
                /*+ '<form asp-action="Excluir">'*/
        +  '<button type="button" class="btn btn-link waves-effect" data-dismiss="modal" id="DeleteButtonConfirmed">SIM</button>'
               /* + '</form>'*/
                 +'<button type="button" class="btn btn-link waves-effect" data-dismiss="modal">FECHAR</button>'
            + '</div>'
      +  '</div>'
              +  '</div>'
        + '</div>');

    $("#DeleteButtonConfirmed").on("click", function ()
    {
        DeleteConfirmationRegister(id_conta);
    })
};


function DeleteConfirmationRegister(id_conta) {
    $.ajax({
        type: "POST",
        url: "/CashFlow/Excluir/" + id_conta,
        data: id_conta,
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    });
    //ReloadGetDespesas();
    window.location.reload(true);

};

function ReloadGetDespesas() {
    //window.location.reload(true);
    getDespesaReceita();
   
};