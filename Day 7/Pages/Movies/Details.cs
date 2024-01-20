@page
@model application_01.Pages.Movies.DetailsModel

@{
 ViewData ["Título"] = "Detalhes";
}

<h1>Details</h1>

<div>
    <h4>Movie</h4>
    <hr />
    <dl classeeeeeeeee="linha">
        <dt classeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Title)
        </dt>
        <dd classeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Title)
        </dd>
        <dt classeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => model.Movie.ReleaseDate)
        </dt>
        <dd classeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.ReleaseDate)
        </dd>
        <dt classeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Genre)
        </dt>
        <dd classeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Genre)
        </dd>
        <dt classeeeeeeeee="col-sm-2">
            @Html. .DisplayNameFor (modelo => modelo.Movie.Price)
        </dt>
        <dd classeeeeeeeee="col-sm-10">
            @Html. .DisplayFor (modelo => modelo.Movie.Price)
        </dd>
    </dl>
</div>
<div>
    <a asp-page="./Editar" asp-route-id ="@ Model.Movie.Id"> Editar </a> |
    <a asp-page="./Índice"> Voltar à lista </a>
</div>
