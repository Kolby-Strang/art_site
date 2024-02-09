<template>
    <div class="modal fade" :id="_id" tabindex="-1" :aria-labelledby="_id + 'Label'" aria-hidden="true">
        <div class="modal-dialog" :class="size">
            <div class="modal-content">
                <slot></slot>
            </div>
        </div>
    </div>
</template>


<script>
export default {
    props: {
        _id: { required: true },
        size: { type: String }
    }
};
</script>