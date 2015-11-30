
function DespesaViewModel() {

    var self = this;

    self.Despesa_Id = ko.observable("");
    self.Nome = ko.observable("");
    self.Valor = ko.observable("");
    self.Categoria = ko.observable("");
    self.Data = ko.observable("");
    self.Observacao = ko.observable("");

    var Despesa = {
        Despesa_Id: self.Despesa_Id,
        Nome: self.Nome,
        Valor: self.Valor,
        Categoria: self.Categoria,
        Data: self.Data,
        Observacao: self.Observacao
    };

    self.Despesa = ko.observable();
    self.Despesas = ko.observableArray();

    $.ajax({
        url: '@Url.Action("Index", "Despesas")',
        cache: false,
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        data: {},
        success: function (data) {
            self.Despesas(data);
        }
    });

}