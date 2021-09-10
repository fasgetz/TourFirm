import { createApp } from 'vue'
import searchedcomponent from './searchedcomponent.vue'

const vueApp = createApp({
    components: {
        searchedcomponent
    },
    data() {
        return {
            /*searchHotels: null*/
        }
    },
    computed: {

    },
    methods: {

    },
    mounted() {
        //axios.get('/Tour/getSearchHotels', )
        //    .then(response => {
        //        this.searchHotels = response.data



        //    }).catch(error => {
        //    });

    },
}).mount('#findedhotels');