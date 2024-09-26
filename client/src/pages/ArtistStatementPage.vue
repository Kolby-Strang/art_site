<template>
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <p class="fs-1">
                    Artist Statement
                </p>
            </div>
            <div class="col-12 col-sm-6 mb-4 order-0 order-sm-0">
                <p>
                    The human experience relies on developing relationships and connection with others. These things,
                    although not physically tangible, evolve in the spaces within and between two individuals. These spaces
                    are dynamic
                    and complicated. My work explores these ideas abstractly, utilizing color, negative space, and the
                    repetition of
                    geometric form.
                </p>
            </div>
            <div class="col-12 col-sm-6 mb-4 order-1 order-sm-1 d-flex justify-content-center">
                <FastImage _class="img-fluid mvh-50 rounded border-secondary"
                    _src="https://photos.strangkolby.com/art-site/the-ties-that-bind/0.jpeg"
                    _alt="sculpture: The ties that bind" />
            </div>
            <div class="col-12 col-sm-6 mb-4 order-3 order-sm-2 d-flex justify-content-center">
                <FastImage _class="img-fluid mvh-50 rounded border-secondary"
                    _src="https://photos.strangkolby.com/art-site/chaos-contained/0.jpeg"
                    _alt="Sculpture: Chaos Contained" />
            </div>
            <div class="col-12 col-sm-6 mb-4 order-2 order-sm-3">
                <p>
                    Choosing to work in salvaged steel, I am drawn to its materiality. It has a nature of permanence and
                    weight that
                    occupies a space so fully that it has to be recognized and navigated. It is imperfect, flawed,
                    discarded, and
                    renewed. Moments of beauty and ugliness can be discovered within my sculptures, representative of what
                    can be found
                    within the hearts and minds of humankind and our relationships with one another.
                </p>
            </div>
        </div>
    </div>
</template>


<script>
import FastImage from '../components/FastImage.vue';

export default {
    setup() {
        return {};
    },
    components: { FastImage }
};
</script>


<style lang="scss" scoped>
.border-secondary {
    border: solid 1px;
}
</style>