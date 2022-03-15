<template>
    <div class="profile-page">
        <section class="section-profile-cover section-shaped my-0">
            <div class="shape shape-style-1 shape-primary shape-skew alpha-4">
                <span></span>
                <span></span>
                <span></span>
                <span></span>
                <span></span>
                <span></span>
                <span></span>
            </div>
        </section>
        <section class="section section-skew" v-if="user">
            <div class="container">
                <card shadow class="card-profile mt--300" no-body>
                    <div class="px-4">
                        <div class="row justify-content-center">
                            <div class="col-lg-3 order-lg-2">
                                <div class="card-profile-image">

                                </div>
                            </div>

                        </div>
                        <div class="text-center mt-5">
                            <h3>
                                <span v-text="user.firstName"></span><span v-text="user.lastName"></span>
                                <span class="font-weight-light">, 27</span>
                            </h3>
                            <div class="h6 font-weight-300"><span v-text="user.email"></span> </div>

                        </div>
                        <div class="mt-5 py-5 border-top text-center">
                            <div class="row justify-content-center">
                                <div class="col-lg-9">

                                    <div class="row justify-content-center">
                                        <div class="col-lg-12">
                                            <div class="row row-grid">
                                                <div class="col-lg-4 mt-5" v-for="(item,i) in books" :key="i">
                                                    <card class="border-0" hover shadow body-classes="py-5 ">
                                                        <icon name="ni ni-check-bold"
                                                              type="primary"
                                                              rounded
                                                              class="mb-4"></icon>
                                                        <h6 class="text-primary text-uppercase">{{item.name}}</h6>
                                                        <p class="description mt-3">
                                                            {{item.text.substring(0, 60)}} ...
                                                        </p>
                                                        <div>
                                                            <badge type="success" rounded>R <span>{{item.price}}</span> Per Month</badge>

                                                        </div>
                                                        <base-button tag="a"
                                                                     v-on:click="unsubscribe(i)"
                                                                     href="#"
                                                                     type="primary"
                                                                     class="mt-4">Unsubscribe</base-button>
                                                    </card>
                                                </div>

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </card>
            </div>
        </section>
    </div>
</template>
<script>
    import { api } from '../../helpers/helpers'

    export default {
        data() {
            return {
                skip: 0,
                take: 10,
                user: null,
                books: []
            }
        },
        components: {},
        async created() {
            var result = api.getUser();
            if (result == null) this.$router.push('/login')
            this.user = result;
            await this.GetBooks()
        },
        methods: {
            async unsubscribe(i) {
                if (this.user) {
                    const result = await api.get(
                        '/subscription/unsubscribe?userId=' + this.user.id + '&bookId=' + this.books[i].id
                    )
                    if (result) {
                        this.books[i].unsubscribed = true;
                    }
                }
               
            },
            async GetBooks() {
                const result = await api.get(
                    '/book/personal/list?userId='+this.user.id+'&take=' + this.take + '&skip=' + this.skip
                )
                if (result && !result.error) {
                    this.books = result.data;
                }

            }
        }

    };
</script>
<style>
</style>
