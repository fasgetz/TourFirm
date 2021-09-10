<template>
    <div>
        <a href="#">
            <div class="popular-item">
                <div class="popular-item__price" v-if="tour.minPriceDay != null">
                    от {{(tour.randDays * tour.minPriceDay).toLocaleString()}} ₽
                </div>
                <img v-bind:src="'img/presentTours/' + tour.imagePath" alt="">
                <h5 class="popular-item__country">{{tour.country}}, {{tour.city}}</h5>
                <div class="popular-item__days"><span>{{tour.randDays}}</span> суток на одного</div>
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