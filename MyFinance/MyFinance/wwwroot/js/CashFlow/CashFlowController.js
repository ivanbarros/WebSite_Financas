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
};

function DetalhePlanoConta(id) {
    $('#renderEditView').load("/CashFlow/Detalhes?id=" + id);
};

function ExcluirConta(id_conta) {
    window.location.href = "../PlanoConta/ExcluirPlanoConta/" + id_conta;
}
