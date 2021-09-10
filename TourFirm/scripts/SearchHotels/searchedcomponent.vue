<template>
    <div class="row mt-3">
        <div v-for="item in searchHotels" class="col-lg-6 col-12 mt-3 mt-lg-0 d-flex justify-content-center">
            <tourcomponent v-bind:tour=item></tourcomponent>
        </div>
    </div>
    <div class="d-flex justify-content-center mt-3">
        <a class="btn btn-outline-secondary" href="#">Все направления</a>
    </div>
</template>

<script>

    import axios from 'axios'
    import tourcomponent from './tourcomponent.vue'


    export default {
        name: "searchedcomponent",
        components: {
            tourcomponent
        },
        props: ['country', 'days', 'humans'],
        data() {
            return {
                searchHotels: null
            }
        },
        mounted() {

            axios.get('/Tour/getSearchHotels', {
                params:
                {
                    idCountry: this.country,
                    days: this.days,
                    countHumans: this.humans
                }
            })
                .then(response => {
                    this.searchHotels = response.data


                }).catch(error => {

                });
        }
    }
</script>