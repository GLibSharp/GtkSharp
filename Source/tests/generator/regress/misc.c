/* This file gets installed, so we can't assume config.h is available */
#ifdef HAVE_CONFIG_H
#include "config.h"
#endif

#include "misc.h"


/**
 * regress_misc_array_parameter_with_length_parameter_shared:
 * @length: Length of the array1 and array2.
 * @array1: (array length=length): First array.
 * @array2: (array length=length): Second array.
 */
void regress_misc_array_parameter_with_length_parameter_shared (gint length, RegressFooObject* array1, guint8* array2)
{
  return;
}

/**
 * regress_misc_array_marshalling_with_uint_length:
 * @formats: (array length=len) (nullable): an array of raw int, or %NULL
 * @len: the size of @formats
 * @layout: the layout of audio samples
 *
 */
void regress_misc_array_marshalling_with_uint_length (const RegressFooObject* formats, guint len, int layout)
{}