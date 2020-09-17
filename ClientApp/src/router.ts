import Vue from 'vue';
import Router from 'vue-router';
import Auth from './views/Authenticate.vue';

Vue.use(Router);

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'Authenticate',
      component: Auth,
    },

  ],
});
