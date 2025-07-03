int empregado, bicicletas_venda, valor_venda;
double salario_min, preco_custo, preco_final, preco_bicicleta_final, comissao_por_func, salario_final, lucro_loja, gasto_loja, comissao_total, receita_loja, gasto_func;

Console.WriteLine("Escreva o numero de empregados:");
empregado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escreva o salário mínimo:");
salario_min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bicicletas vendidas: ");
bicicletas_venda = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valor Bicicleta: ");
preco_custo = Convert.ToInt32(Console.ReadLine());

preco_final = preco_custo * 1.5;

receita_loja = preco_final * bicicletas_venda;

comissao_total = (preco_custo * 0.15) * bicicletas_venda;

comissao_por_func = ((preco_custo * 0.15) * bicicletas_venda) / empregado;

gasto_loja = empregado * (2 * salario_min + comissao_total);

salario_final = (salario_min * 2) + comissao_por_func;

gasto_func = salario_final * empregado;

Console.WriteLine("O gasto por funcionario é: " + Math.Round(gasto_func, 2));

Console.WriteLine("O valor da bicileta é: " + Math.Round(preco_final, 2));

Console.WriteLine("O valor da comissão total é: " + Math.Round(comissao_total, 2));

Console.WriteLine("O valor da comissão por funcionário é: " + Math.Round(comissao_por_func, 2));

Console.WriteLine("O valor salário final é: " + Math.Round(salario_final, 2));

lucro_loja = (receita_loja - gasto_func);

if (lucro_loja > 0)
{
    Console.WriteLine("O lucro da loja é: R$ " + Math.Round(lucro_loja, 2) + " esse mês");
}
if (lucro_loja < 0)
{
    Console.WriteLine("A loja está com R$ " + Math.Round(lucro_loja, 2) + " de prejuízo esse mês");
}
if (lucro_loja == 0)
{
    Console.WriteLine("A loja não teve lucro esse mês");
}