import { createApp } from 'vue'
import axios from 'axios'
import tourcomponent from './tourcomponent.vue'

const vueApp = createApp({
    components: {
        tourcomponent
    },
    data() {
        return {
            popularTours: null,
            randomTours: null
        }
    },
    computed: {

    },
    methods: {

    },
    mounted() {
        axios.get('/Tour/GetLastPopularTours')
            .then(response => {
                this.popularTours = response.data

                console.log(response.data)


            }).catch(error => {
                console.log(error.response.data)
            });

        axios.get('/Tour/GetRandomTours')
            .then(response => {
                this.randomTours = response.data

                console.log(response.data)


            }).catch(error => {
                console.log(error.response.data)
            });
    },
}).mount('#app');