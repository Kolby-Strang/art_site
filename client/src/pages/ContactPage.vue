<template>
    <div class="row">
        <div class="col-6">
            <div class="d-flex justify-content-center align-items-center fs-2">
                <i class="mdi mdi-instagram"></i>
                <p class="text-secondary mb-0">Instagram</p>
            </div>
            <InstagramEmbed />
        </div>
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