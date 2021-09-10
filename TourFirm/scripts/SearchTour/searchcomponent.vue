<template>
    <form id="searchtour" asp-action="Search" asp-controller="Tour" class="row mt-lg-5 mt-3">
        <div class="form-group col-12 col-xl col-lg-4">
            <label for="exampleFormControlSelect1">Город вылета</label>
            <select class="form-control" id="exampleFormControlSelect1">
                <option>Москва</option>
                <option>Санкт-Петербург</option>
                <option>Екатеринбург</option>
                <option>Новосибирск</option>
                <option>Самара</option>
            </select>
        </div>
        <div class="form-group mt-1 mt-lg-0 col-12 col-xl col-lg-4">
            <label for="exampleFormControlSelect1">Страна пребывания</label>
            <select v-model="selectedCountryId" class="form-control" id="exampleFormControlSelect1">
                <option v-for="item in countries" v-bind:value="item.id">{{item.name}}</option>
            </select>
        </div>
        <div class="form-group mt-1 mt-lg-0 col-12 col-xl col-lg-4">
            <label for="exampleFormControlSelect1">Дата вылета</label>
            <input class="form-control" type="date">
        </div>
        <div class="form-group mt-1 mt-lg-3 mt-xl-0 col-12 col-xl col-lg-6">
            <label for="exampleFormControlTextarea1">На сколько суток</label>
            <select v-model="selectedDays" class="form-control" id="exampleFormControlSelect1">
                <option>1</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
                <option>6</option>
                <option selected>7</option>
                <option>8</option>
                <option>9</option>
                <option>10</option>
                <option>11</option>
                <option>12</option>
                <option>13</option>
                <option>14</option>
            </select>
        </div>
        <div class="form-group mt-1 mt-lg-3 mt-xl-0 col-12 col-xl col-lg-6">
            <label for="exampleFormControlTextarea1">Сколько человек</label>
            <select v-model="selectedHumans" class="form-control" id="exampleFormControlSelect1">
                <option selected>1</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
                <option>5</option>
            </select>
        </div>
        <div class="form-group mt-3 mt-lg-3 mt-xl-0 col-12 col-xl col-lg-12 d-flex align-items-end justify-content-center">
            <div class="search-button w-50">
                <button v-on:click="searchTour" class="btn btn-primary w-100">Найти туры</button>
            </div>
        </div>
    </form>
</template>

<script>

    import axios from 'axios'

    export default {
        name: "searchcomponent",
        props: ['country', 'days', 'humans'],
        data() {
            return {
                countries: null,
                selectedCountryId: 1,
                selectedDays: 7,
                selectedHumans: 2
            }
        },
        computed: {

        },
        methods: {
            searchTour: function () {
                event.preventDefault()

                window.location = "/Tour/Search?idCountry=" + this.selectedCountryId + "&days=" + this.selectedDays + "&countHumans=" + this.selectedHumans
                //axios.get('/Tour/Search', {
                //    params:
                //    {
                //        idCountry: this.selectedCountryId,
                //        days: this.selectedDays,
                //        countHumans: this.selectedHumans
                //    }
                //})
                //    .then(response => {
                //        $("#main").html(response.data)


                //    }).catch(error => {

                //    });


            }
        },
        mounted() {
            axios.get('/CountryCities/GetCountriesTour')
                .then(response => {
                    this.countries = response.data


                }).catch(error => {

                });



            this.selectedDays = this.days
            this.selectedHumans = this.humans
            this.selectedCountryId = this.country



        }
    }
</script>