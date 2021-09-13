<template>
    <div class="container payment-form" v-if="hotelJson != null">
        <div class="row justify-content-center">
            <div class="col-12 col-lg-9">
                <h3 class="mt-3 text-center">Оплата отеля <b>{{hotelJson.NameHotel}}</b></h3>
                <div class="hotel__img_block d-flex justify-content-center mt-3 mb-3">
                    <img v-bind:src="'/img/presentTours/' + hotelJson.PresentImagePath" alt="Alternate Text" />
                </div>
                <div class="hotel_description">
                    {{hotelJson.DescriptionTour}}
                </div>
                <div class="mt-3">
                    <label>Класс номера в отеле</label>
                    <select v-model="selectedHotelClass" class="form-control">
                        <option disabled value="0">Выберите класс номера в отеле</option>
                        <option v-for="item in hotelJson.HotelPrices" v-bind:value="item">{{item.IdCategoryHotelNumberNavigation.Name}} — {{item.PriceDay}}₽</option>
                    </select>
                </div>
                <div class="mt-3">
                    <label>Количество человек</label>
                    <select @change="onChangeHumans(selectedHumans)" v-model="selectedHumans" class="form-control">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                </div>
                <div class="mt-3">
                    <label>Количество суток</label>
                    <select v-model.number="selectedDays" class="form-control">
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                        <option>6</option>
                        <option>7</option>
                        <option>8</option>
                        <option>9</option>
                        <option>10</option>
                        <option>11</option>
                        <option>12</option>
                        <option>13</option>
                        <option>14</option>
                        <option>15</option>
                        <option>16</option>
                        <option>17</option>
                        <option>18</option>
                        <option>19</option>
                        <option>20</option>
                        <option>21</option>
                    </select>
                </div>
                <div class="person-data mt-3" v-for="item in parseInt(selectedHumans)" :key="item">
                    <div class="mt-3 mb-3">
                        <b>Данные на туриста №{{item}}</b>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Имя</label>
                        <input type="text" class="form-control" v-model="humansData[item-1].name" placeholder="Имя">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Фамилия</label>
                        <input type="text" class="form-control" v-model="humansData[item-1].family" placeholder="Имя">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Отчество</label>
                        <input type="text" class="form-control" v-model="humansData[item-1].lastname" placeholder="Имя">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Дата рождения</label>
                        <input type="date" class="form-control" v-model="humansData[item-1].datebirth" placeholder="Дата рождения">
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Серия и номер паспорта</label>
                        <input type="text" class="form-control" v-model="humansData[item-1].passport" placeholder="Серия и номер паспорта">
                    </div>

                </div>
                <div v-if="selectedHotelClass != 0" class="mt-3">
                    <div class="search-button d-flex justify-content-center">
                        <button v-on:click="payHotel" class="btn btn-primary">Оплатить {{selectedHumans * selectedDays * selectedHotelClass.PriceDay}}₽</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'

    export default {
        name: "paymentcomponent",
        props: ['hotel'],
        data() {
            return {
                //hotel: null,
                hotelJson: null,
                selectedHotelClass: 0,
                selectedHumans: 1,
                selectedDays: 5,
                humansData: []
            }
        },
        methods: {
            payHotel: function () {

                axios.post('/Payment/PayHotel', obj)
                    .then(response => {

                        console.log(response.data)


                    }).catch(error => {

                    });
            },
            onChangeHumans: function (humans) {

                this.humansData = []

                for (let i = 0; i < humans; i++) {

                    var human = {
                        name: null,
                        family: null,
                        lastname: null,
                        datebirth: null,
                        passport: null
                    }

                    this.humansData.push(human)
                }
            }
        },
        mounted() {
                this.hotelJson = JSON.parse(this.hotel)

                this.onChangeHumans(this.selectedHumans)
                




        },
    }
</script>