<template>
    <div class="d-flex flex-column align-items-center mb-3">
        <div class="d-flex justify-content-center align-items-center fs-2">
            <i class="mdi mdi-instagram"></i>
            <p class="text-secondary mb-0">Instagram</p>
        </div>
        <InstagramEmbed />
        <div class="d-flex justify-content-center align-items-center fs-2 mt-3">
            <i class="mdi mdi-phone"></i>
            <p class="text-secondary mb-0">Phone</p>
        </div>
        <a href="tel:+13605362487">(360)536-2487</a>
    </div>
</template>


<script>
import InstagramEmbed from '../components/InstagramEmbed.vue';
export default {
    setup() {
        return {}
    },
    components: { InstagramEmbed }
};
</script>


<style lang="scss" scoped></style>