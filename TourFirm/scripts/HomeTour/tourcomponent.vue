<template>
    <div class="tour-item">
        <a v-bind:href="'/Tour/About?idHotel='+ tour.id">
            <div class="popular-item">
                <div class="popular-item__price" v-if="tour.minPriceDay != null">
                    от {{(tour.randDays * tour.minPriceDay).toLocaleString()}} ₽
                </div>
                <img v-bind:src="'img/presentTours/' + tour.imagePath" alt="">
                <h5 class="popular-item__country">{{tour.country}}, {{tour.city}}</h5>
                <div class="popular-item__days"><span>{{tour.randDays}}</span> суток на одного</div>
                <div class="popular-item__nameHotel w-100 text-center"><span>{{tour.hotelName}}</span></div>
            </div>
        </a>
    </div>
</template>

<script>


    export default {
        name: "tourcomponent",
        props: ['tour']
    }
</script>