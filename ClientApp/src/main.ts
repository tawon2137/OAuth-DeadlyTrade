import Vue from 'vue';
import Buefy from 'buefy'
import App from './App.vue';
import router from './router';


import '@/assets/style/index.scss';

Vue.config.productionTip = false;
Vue.use(Buefy, {
  defaultIconPack: 'mdi',
  // defaultContainerElement: '#app',
});
new Vue({
  router,
  render: (h) => h(App),
}).$mount('#app');
