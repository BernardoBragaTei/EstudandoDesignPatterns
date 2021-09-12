using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using System;

MassasAbstractFactory fabrica1 = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Pizza);

var pizza1 = fabrica1.CriarMassa((TipoMassa)TipoPizza.Calabresa);
var pizza2 = fabrica1.CriarMassa((TipoMassa)TipoPizza.Mussarela);

MassasAbstractFactory fabrica2 = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Bolo);

var bolo1 = fabrica2.CriarMassa((TipoMassa)TipoBolo.Chocolate);
var bolo2 = fabrica2.CriarMassa((TipoMassa)TipoBolo.Laranja);

pizza1.ExibirDetalhes();
pizza2.ExibirDetalhes();
bolo1.ExibirDetalhes();
bolo2.ExibirDetalhes();