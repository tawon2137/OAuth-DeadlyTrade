import Vue from 'vue';
import GAuth from 'vue-google-oauth2';

const gauthOption = {
    clientId: '727179684643-j8nqb0h5fftd2qoq54gnnrfjs6c3bkns.apps.googleusercontent.com',
    scope: 'email',
    prompt: 'select_account'
}

Vue.use(GAuth, gauthOption);