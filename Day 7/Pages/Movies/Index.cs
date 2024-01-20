@page
@model application_01.Pages.Movies.IndexModel

@{
 ViewData ["Título"] = "Índice";
}

<h1>Index</h1>

<p>
    <a asp-page="Criar"> Crie novo </a>
</p>
<table classe="mesa">
    <thead>
        <tr>
            <th>
                @Html. .DisplayNameFor (modelo => modelo.Movie [0] .Título)
            </th>
            <th>
                @Html. . .DisplayNameFor (modelo => modelo.Movie [0] .ReleaseDate)
            </th>
            <th>
                @Html. . . .DisplayNameFor (modelo => modelo.Movie [0] .Gênero)
            </th>
            <th>
                @Html. . . . .DisplayNameFor (modelo => modelo.Movie [0] .Preço)
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
@foreach (var item não Modelo. .Movie) {
        <tr>
            <td>
                @Html. .DisplayFor (modelItem => item.Título)
            </td>
            <td>
                @Html. .DisplayFor (modelItem => item.ReleaseDate)
            </td>
            <td>
                @Html. .DisplayFor (modelItem => item.Genre)
            </td>
            <td>
                @Html. .DisplayFor (modelItem => item.Preço)
            </td>
            <td>
                <a asp-page="./Editar" asp-route-id ="@ item.Id"> Editar </a> |
                <a asp-page="./ Detalhes" asp-route-id ="@ item.Id"> Detalhes </a> |
                <a asp-page="./ Excluir" asp-route-id ="@ item.Id"> Excluir </a>
            </td>
        </tr>
}
    </tbody>
</table>
