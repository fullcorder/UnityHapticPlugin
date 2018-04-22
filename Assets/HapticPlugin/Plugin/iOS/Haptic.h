#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

typedef enum
{
    Selection,
    ImpactLight,
    ImpactMedium,
    ImpactHeavy,
    NortificationSuccess,
    NortificationWarning,
    NortificationError,
} FeedbackType;

#ifdef __cplusplus
extern "C" {
#endif

bool _Haptic_supported();

void _Haptic_generate(FeedbackType type);

#ifdef __cplusplus
}
#endif
